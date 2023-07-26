using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class F399DFB5
{
	private struct DC9DAB9C
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		internal bool bool_0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		internal string A438D10D;

		public bool Boolean_0
		{
			[CompilerGenerated]
			get
			{
				return bool_0;
			}
			[CompilerGenerated]
			set
			{
				bool_0 = value;
			}
		}

		public string String_0
		{
			[CompilerGenerated]
			get
			{
				return A438D10D;
			}
			[CompilerGenerated]
			set
			{
				A438D10D = value;
			}
		}
	}

	private static class Class1
	{
		internal const string string_0 = "Folders|\n";

		internal const BindingFlags bindingFlags_0 = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		internal static readonly Assembly assembly_0 = typeof(FileDialog).Assembly;

		internal static readonly Type type_0 = assembly_0.GetType("System.Windows.Forms.FileDialogNative+IFileDialog");

		internal static readonly MethodInfo methodInfo_0 = typeof(OpenFileDialog).GetMethod("CreateVistaDialog", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		internal static readonly MethodInfo F5886DA9 = typeof(OpenFileDialog).GetMethod("OnBeforeVistaDialog", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		internal static readonly MethodInfo methodInfo_1 = typeof(FileDialog).GetMethod("GetOptions", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		internal static readonly MethodInfo F3851DB8 = type_0.GetMethod("SetOptions", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		internal static readonly uint uint_0 = (uint)assembly_0.GetType("System.Windows.Forms.FileDialogNative+FOS").GetField("FOS_PICKFOLDERS").GetValue(null);

		internal static readonly ConstructorInfo constructorInfo_0 = assembly_0.GetType("System.Windows.Forms.FileDialog+VistaDialogEvents").GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof(FileDialog) }, null);

		internal static readonly MethodInfo FB3DEEB0 = type_0.GetMethod("Advise");

		internal static readonly MethodInfo A438A722 = type_0.GetMethod("Unadvise");

		internal static readonly MethodInfo DB174320 = type_0.GetMethod("Show");

		public static DC9DAB9C smethod_0(IntPtr intptr_0, string ABACD59C, string D50B86AA)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				AddExtension = false,
				CheckFileExists = false,
				DereferenceLinks = true,
				Filter = "Folders|\n",
				InitialDirectory = ABACD59C,
				Multiselect = false,
				Title = D50B86AA
			};
			object obj = methodInfo_0.Invoke(openFileDialog, new object[0]);
			F5886DA9.Invoke(openFileDialog, new object[1] { obj });
			F3851DB8.Invoke(obj, new object[1] { (uint)methodInfo_1.Invoke(openFileDialog, new object[0]) | uint_0 });
			object[] array = new object[2]
			{
				constructorInfo_0.Invoke(new object[1] { openFileDialog }),
				0u
			};
			FB3DEEB0.Invoke(obj, array);
			try
			{
				int num = (int)DB174320.Invoke(obj, new object[1] { intptr_0 });
				DC9DAB9C result = default(DC9DAB9C);
				result.Boolean_0 = num == 0;
				result.String_0 = openFileDialog.FileName;
				return result;
			}
			finally
			{
				A438A722.Invoke(obj, new object[1] { array[1] });
			}
		}
	}

	private class Class2 : IWin32Window
	{
		internal readonly IntPtr intptr_0;

		public IntPtr Handle => intptr_0;

		public Class2(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
		}
	}

	internal string string_0;

	internal string string_1;

	internal string string_2 = "";

	public string String_0
	{
		get
		{
			return string.IsNullOrEmpty(string_0) ? Environment.CurrentDirectory : string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public string String_1
	{
		get
		{
			return string_1 ?? "Select a folder";
		}
		set
		{
			string_1 = value;
		}
	}

	public string String_2 => string_2;

	public bool A00CD39B()
	{
		return method_0(IntPtr.Zero);
	}

	public bool method_0(IntPtr BB2573B7)
	{
		DC9DAB9C dC9DAB9C = ((Environment.OSVersion.Version.Major >= 6) ? Class1.smethod_0(BB2573B7, String_0, String_1) : FF939212(BB2573B7, String_0, String_1));
		string_2 = dC9DAB9C.String_0;
		return dC9DAB9C.Boolean_0;
	}

	private static DC9DAB9C FF939212(IntPtr D1AB27BA, string string_3, string string_4)
	{
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
		{
			Description = string_4,
			SelectedPath = string_3,
			ShowNewFolderButton = false
		};
		DC9DAB9C result = default(DC9DAB9C);
		if (folderBrowserDialog.ShowDialog(new Class2(D1AB27BA)) == DialogResult.OK)
		{
			result.Boolean_0 = true;
			result.String_0 = folderBrowserDialog.SelectedPath;
		}
		return result;
	}
}
