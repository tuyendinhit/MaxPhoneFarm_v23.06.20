using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

public class OrderDetail
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int CB9C7A25;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_3;

	[JsonProperty("id")]
	public int A2BDAC1E
	{
		[CompilerGenerated]
		get
		{
			return CB9C7A25;
		}
		[CompilerGenerated]
		set
		{
			CB9C7A25 = value;
		}
	}

	[JsonProperty("object_id")]
	public string BF2F92AA
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	[JsonProperty("type")]
	public string CEB2DD02
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	[JsonProperty("quantity")]
	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	[JsonProperty("comment")]
	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}
}
