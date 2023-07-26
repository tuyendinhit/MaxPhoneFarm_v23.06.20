using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

public class GClass1
{
    public static List<string> GetDevices()
    {
        List<string> list = new List<string>();
        Process process = new Process();
        try
        {
            process.StartInfo = new ProcessStartInfo
            {
                FileName = Environment.GetEnvironmentVariable("ANDROID_HOME", EnvironmentVariableTarget.Machine) + "\\platform-tools\\adb.exe",
                Arguments = " devices",
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            process.Start();
            string text = process.StandardOutput.ReadToEnd();
            string[] array = text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string text2 in array)
            {
                if (!text2.Contains("offline"))
                {
                    Regex regex = new Regex("([^/]+) device product:([^/]+) model");
                    if (regex.Match(text2).Success)
                    {
                        Match match = regex.Match(text2);
                        list.Add(match.Groups[1].Value.ToString().Trim());
                    }
                    else if (string.Compare(text2.Trim(), "", false) != 0 && !text2.Contains("List of devices attached"))
                    {
                        text2.Split("\\t ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        list.Add(text2.Replace("device", "").Trim());
                    }
                }
            }
        }
        catch (Exception)
        {
        }
        return list;
    }

    public static string D22E1AB1(string CFA80123, int A8B7D59D = 10)
	{
		int num = 0;
		int num2 = 3;
		string result = "";
		try
		{
			string string_0;
			string E698B615;
			while (true)
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/c " + Environment.GetEnvironmentVariable("ANDROID_HOME", EnvironmentVariableTarget.Machine) + "\\platform-tools\\" + CFA80123;
				process.StartInfo.Verb = "runas";
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardError = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
				process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
				string_0 = "";
				process.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
				{
					if (!string.IsNullOrEmpty(e.Data))
					{
						string_0 = string_0 + e.Data + "\n";
					}
				};
				E698B615 = "";
				process.ErrorDataReceived += delegate(object sender, DataReceivedEventArgs e)
				{
					if (!string.IsNullOrEmpty(e.Data))
					{
						E698B615 = E698B615 + e.Data + "\n";
					}
				};
				process.Start();
				process.BeginOutputReadLine();
				process.BeginErrorReadLine();
				bool flag = !process.WaitForExit((A8B7D59D >= 0) ? (A8B7D59D * 1000) : (-1));
				process.Close();
				if (flag && !CFA80123.StartsWith("scrcpy"))
				{
					if (num > 0 && num % num2 == 0)
					{
						smethod_2();
					}
					num++;
					continue;
				}
				if (!(E698B615 != ""))
				{
					break;
				}
				if (E698B615.Contains("daemon not running") && !E698B615.Contains("daemon started successfully"))
				{
					continue;
				}
				if (Regex.Match(E698B615, "device (.*?) not found").Groups[1].Value != "")
				{
				}
				break;
			}
			result = string_0.Trim();
		}
		catch
		{
		}
		return result;
	}

	public static Bitmap smethod_1(string string_0)
	{
		string text = "adb shell screencap -p";
		if (!string.IsNullOrEmpty(string_0))
		{
			string newValue = "adb -s " + string_0;
			text = (text.StartsWith("adb") ? text.Replace("adb", newValue) : ("adb -s " + string_0 + " " + text));
		}
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.Arguments = "/c " + Environment.GetEnvironmentVariable("ANDROID_HOME") + "\\platform-tools\\" + text;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.Start();
		Stream baseStream = process.StandardOutput.BaseStream;
		process.Close();
		List<byte> list = new List<byte>(1024);
		int num = 0;
		bool flag = false;
		do
		{
			byte[] array = new byte[1024];
			num = baseStream.Read(array, 0, array.Length);
			for (int i = 0; i < num; i++)
			{
				if (flag && array[i] == 10)
				{
					flag = false;
					list.RemoveAt(list.Count - 1);
					list.Add(array[i]);
				}
				else
				{
					flag = array[i] == 13;
					list.Add(array[i]);
				}
			}
		}
		while (num > 0);
		Bitmap result = null;
		if (list.Count > 0)
		{
			result = new Bitmap(new MemoryStream(list.ToArray()));
		}
		return result;
	}

	public static void smethod_2()
	{
		try
		{
			Common.RunCMD("taskkill /f /im adb.exe");
		}
		catch
		{
		}
	}

	public static void smethod_3()
	{
		try
		{
			D22E1AB1("adb start-server");
		}
		catch
		{
		}
	}
}
