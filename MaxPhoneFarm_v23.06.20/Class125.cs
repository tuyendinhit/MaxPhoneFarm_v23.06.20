using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

[CompilerGenerated]
internal static class Class125
{
	internal static object object_0 = new object();

	internal static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	internal static string BE2FD81A;

	internal static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	internal static Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();

	internal static List<string> list_0 = new List<string>();

	internal static List<string> list_1 = new List<string>();

	internal static Dictionary<string, string> BBA0AE2C = new Dictionary<string, string>();

	internal static int F292C9BF;

	private static string D4ACD2B6(CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			return "";
		}
		return cultureInfo_0.Name;
	}

	private static Assembly smethod_0(AssemblyName assemblyName_0)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		Assembly[] array = assemblies;
		int num = 0;
		Assembly assembly;
		while (true)
		{
			if (num < array.Length)
			{
				assembly = array[num];
				AssemblyName name = assembly.GetName();
				if (string.Equals(name.Name, assemblyName_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(D4ACD2B6(name.CultureInfo), D4ACD2B6(assemblyName_0.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return assembly;
	}

	private static Assembly smethod_1(string D893A789, AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name))
		{
			text = assemblyName_0.CultureInfo.Name + "." + text;
		}
		string path = ((IntPtr.Size == 8) ? "64" : "32");
		string path2 = Path.Combine(D893A789, text + ".dll");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.ChangeExtension(path2, "exe");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.Combine(Path.Combine(D893A789, path), text + ".dll");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.ChangeExtension(path2, "exe");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		return null;
	}

	private static void smethod_2(Stream B503FE05, Stream stream_0)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = B503FE05.Read(array, 0, array.Length)) != 0)
		{
			stream_0.Write(array, 0, count);
		}
	}

	private static Stream smethod_3(string B3847F0F)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (B3847F0F.EndsWith(".compressed"))
		{
			using (Stream stream = executingAssembly.GetManifestResourceStream(B3847F0F))
			{
				using DeflateStream b503FE = new DeflateStream(stream, CompressionMode.Decompress);
				MemoryStream memoryStream = new MemoryStream();
				smethod_2(b503FE, memoryStream);
				memoryStream.Position = 0L;
				return memoryStream;
			}
		}
		return executingAssembly.GetManifestResourceStream(B3847F0F);
	}

	private static Stream BAA2A508(Dictionary<string, string> dictionary_3, string string_0)
	{
		if (dictionary_3.TryGetValue(string_0, out var value))
		{
			return smethod_3(value);
		}
		return null;
	}

	private static byte[] smethod_4(Stream E48FF709)
	{
		byte[] array = new byte[E48FF709.Length];
		E48FF709.Read(array, 0, array.Length);
		return array;
	}

	private static Assembly smethod_5(Dictionary<string, string> dictionary_3, Dictionary<string, string> EBB937B5, AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name))
		{
			text = assemblyName_0.CultureInfo.Name + "." + text;
		}
		byte[] rawAssembly;
		using (Stream stream = BAA2A508(dictionary_3, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = smethod_4(stream);
		}
		using (Stream stream2 = BAA2A508(EBB937B5, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = smethod_4(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	public static Assembly smethod_6(object E2239C81, ResolveEventArgs C1371DAE)
	{
		lock (object_0)
		{
			if (dictionary_0.ContainsKey(C1371DAE.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(C1371DAE.Name);
		Assembly assembly = smethod_0(assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = smethod_1(BE2FD81A, assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = smethod_5(dictionary_1, dictionary_2, assemblyName);
		if ((object)assembly == null)
		{
			lock (object_0)
			{
				dictionary_0[C1371DAE.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	static Class125()
	{
		BBA0AE2C.Add("costura32.main.dll", "0B5F27CAA7EA49791FC35E62EFA32A79FACB1A9F");
		BBA0AE2C.Add("costura64.main.dll", "0B5F27CAA7EA49791FC35E62EFA32A79FACB1A9F");
		dictionary_1.Add("bunifu_ui_v1.52", "costura.bunifu_ui_v1.52.dll.compressed");
		dictionary_1.Add("costura", "costura.costura.dll.compressed");
		dictionary_2.Add("costura", "costura.costura.pdb.compressed");
		dictionary_1.Add("dotnetzip", "costura.dotnetzip.dll.compressed");
		dictionary_1.Add("entityframework", "costura.entityframework.dll.compressed");
		dictionary_1.Add("entityframework.sqlserver", "costura.entityframework.sqlserver.dll.compressed");
		dictionary_1.Add("http", "costura.http.dll.compressed");
		dictionary_1.Add("managedwinapi", "costura.managedwinapi.dll.compressed");
		dictionary_1.Add("microsoft.extensions.logging.abstractions", "costura.microsoft.extensions.logging.abstractions.dll.compressed");
		dictionary_1.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
		dictionary_2.Add("newtonsoft.json", "costura.newtonsoft.json.pdb.compressed");
		dictionary_1.Add("opencvsharp", "costura.opencvsharp.dll.compressed");
		dictionary_1.Add("opencvsharp.extensions", "costura.opencvsharp.extensions.dll.compressed");
		dictionary_1.Add("system.buffers", "costura.system.buffers.dll.compressed");
		dictionary_1.Add("system.data.sqlite", "costura.system.data.sqlite.dll.compressed");
		dictionary_1.Add("system.data.sqlite.ef6", "costura.system.data.sqlite.ef6.dll.compressed");
		dictionary_1.Add("system.data.sqlite.linq", "costura.system.data.sqlite.linq.dll.compressed");
		dictionary_1.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
		dictionary_1.Add("system.drawing.common", "costura.system.drawing.common.dll.compressed");
		dictionary_1.Add("system.runtime.compilerservices.unsafe", "costura.system.runtime.compilerservices.unsafe.dll.compressed");
		dictionary_1.Add("webdriver", "costura.webdriver.dll.compressed");
		dictionary_1.Add("webdriver.support", "costura.webdriver.support.dll.compressed");
		dictionary_1.Add("xnet", "costura.xnet.dll.compressed");
		list_0.Add("costura32.main.dll");
		list_1.Add("costura64.main.dll");
	}

	private static void smethod_7(string D88B6E2D)
	{
		if (!Directory.Exists(D88B6E2D))
		{
			Directory.CreateDirectory(D88B6E2D);
		}
	}

	private static string smethod_8(string string_0)
	{
		string text = ((IntPtr.Size == 8) ? "64" : "32");
		string text2 = string_0;
		if (string_0.StartsWith("costura" + text + "."))
		{
			text2 = Path.Combine(text, string_0.Substring(10));
		}
		else if (string_0.StartsWith("costura."))
		{
			text2 = string_0.Substring(8);
		}
		if (text2.EndsWith(".compressed"))
		{
			text2 = text2.Substring(0, text2.Length - 11);
		}
		return text2;
	}

	private static string smethod_9(string string_0)
	{
		using FileStream stream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
		using BufferedStream inputStream = new BufferedStream(stream);
		using SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] array = sHA1CryptoServiceProvider.ComputeHash(inputStream);
		StringBuilder stringBuilder = new StringBuilder(2 * array.Length);
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.AppendFormat("{0:X2}", b);
		}
		return stringBuilder.ToString();
	}

	[DllImport("kernel32.dll")]
	private static extern uint SetErrorMode(uint uint_0);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr LoadLibraryEx(string string_0, IntPtr intptr_0, uint uint_0);

	private static void D6087608(string string_0, IList<string> DD92BE2B, Dictionary<string, string> dictionary_3)
	{
		foreach (string item in DD92BE2B)
		{
			string path = smethod_8(item);
			string text = Path.Combine(string_0, path);
			if (File.Exists(text))
			{
				string text2 = smethod_9(text);
				if (text2 != dictionary_3[item])
				{
					File.Delete(text);
				}
			}
			if (File.Exists(text))
			{
				continue;
			}
			using Stream b503FE = smethod_3(item);
			using FileStream stream_ = File.OpenWrite(text);
			smethod_2(b503FE, stream_);
		}
		uint errorMode = SetErrorMode(32771u);
		foreach (string item2 in DD92BE2B)
		{
			string path = smethod_8(item2);
			if (path.EndsWith(".dll"))
			{
				string string_ = Path.Combine(string_0, path);
				LoadLibraryEx(string_, IntPtr.Zero, 8u);
			}
		}
		SetErrorMode(errorMode);
	}

	private static void smethod_10(string CE8560AB, string string_0, List<string> list_2, Dictionary<string, string> F02DC911)
	{
		string name = "Costura" + CE8560AB;
		using Mutex mutex = new Mutex(initiallyOwned: false, name);
		bool flag = false;
		try
		{
			try
			{
				if (!(flag = mutex.WaitOne(60000, exitContext: false)))
				{
					throw new TimeoutException("Timeout waiting for exclusive access");
				}
			}
			catch (AbandonedMutexException)
			{
				flag = true;
			}
			string path = ((IntPtr.Size == 8) ? "64" : "32");
			smethod_7(Path.Combine(string_0, path));
			D6087608(string_0, list_2, F02DC911);
		}
		finally
		{
			if (flag)
			{
				mutex.ReleaseMutex();
			}
		}
	}

	public static void smethod_11()
	{
		if (Interlocked.Exchange(ref F292C9BF, 1) == 1)
		{
			return;
		}
		AppDomain currentDomain = AppDomain.CurrentDomain;
		object obj = currentDomain.GetType()?.GetProperty("SetupInformation")?.GetValue(currentDomain);
		PropertyInfo propertyInfo = obj?.GetType()?.GetProperty("TargetFrameworkName");
		if ((object)propertyInfo != null && propertyInfo.GetValue(obj) == null)
		{
			string text = ((TargetFrameworkAttribute)(Assembly.GetCallingAssembly()?.GetCustomAttribute(typeof(TargetFrameworkAttribute))))?.FrameworkName;
			if (text != null)
			{
				currentDomain.SetData("TargetFrameworkName", text);
			}
		}
		string text2 = "BAB27B2959E50FCA36A4A853B9082F48";
		string path = Path.Combine(Path.GetTempPath(), "Costura");
		BE2FD81A = Path.Combine(path, text2);
		List<string> list_ = ((IntPtr.Size == 8) ? list_1 : list_0);
		smethod_10(text2, BE2FD81A, list_, BBA0AE2C);
		currentDomain.AssemblyResolve += delegate(object E2239C81, ResolveEventArgs C1371DAE)
		{
			lock (object_0)
			{
				if (dictionary_0.ContainsKey(C1371DAE.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(C1371DAE.Name);
			Assembly assembly = smethod_0(assemblyName);
			if ((object)assembly != null)
			{
				return assembly;
			}
			assembly = smethod_1(BE2FD81A, assemblyName);
			if ((object)assembly != null)
			{
				return assembly;
			}
			assembly = smethod_5(dictionary_1, dictionary_2, assemblyName);
			if ((object)assembly == null)
			{
				lock (object_0)
				{
					dictionary_0[C1371DAE.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		};
	}
}
