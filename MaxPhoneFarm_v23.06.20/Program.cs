using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

internal static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		if (args.Length != 0 && args[0] == "a")
		{
			Application.Run(new fCheckAppium());
			return;
		}
		try
		{
			if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				MessageBoxHelper.Show("Vui lòng chạy bằng quyền Admin!\r\nPlease Run Aplication As Administrator!", 3);
				Environment.Exit(0);
			}
			string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
			if (File.Exists(path))
			{
				try
				{
					List<string> list = new List<string> { "minsoftware" };
					using StreamReader streamReader = new StreamReader(path);
					string empty = string.Empty;
					while ((empty = streamReader.ReadLine()) != null)
					{
						foreach (string item in list)
						{
							if (empty.ToLower().Contains(item))
							{
								MessageBoxHelper.Show("Vui lòng cấu hình lại file hosts nếu muốn mở phần mềm!", 2);
								Environment.Exit(0);
							}
						}
					}
				}
				catch
				{
					MessageBoxHelper.Show("Vui lòng cấu hình lại file hosts nếu muốn mở phần mềm!", 2);
					Environment.Exit(0);
				}
			}
			SetupFolder.CreateBasicFolder();
			Application.Run(new fIntro());
		}
		catch (Exception exception_)
		{
			MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng liên hê\u0323 Admin đê\u0309 đươ\u0323c hô\u0303 trơ\u0323!"), 2);
			Common.ExportError(null, exception_, "Run Program2");
			Environment.Exit(0);
		}
	}
}
