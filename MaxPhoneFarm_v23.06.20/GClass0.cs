using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

public class GClass0
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Thread thread_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_0 = 0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int int_1;

	private Thread Thread_0
	{
		[CompilerGenerated]
		get
		{
			return thread_0;
		}
		[CompilerGenerated]
		set
		{
			thread_0 = value;
		}
	}

	private int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	private int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public GClass0(Thread B019AAA5, int int_2 = -1)
	{
		Thread_0 = B019AAA5;
		Int32_1 = int_2;
	}

	public void method_0()
	{
		Int32_0 = Environment.TickCount;
		if (Int32_1 <= 0)
		{
			return;
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				while (Environment.TickCount - Int32_0 < Int32_1 * 1000 && Thread_0.IsAlive)
				{
					Thread.Sleep(1000);
				}
				Thread_0.Abort();
				while (Thread_0.IsAlive)
				{
					Thread.Sleep(1000);
				}
			}
			catch (Exception)
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	public string method_1()
	{
		if (Int32_0 == 0)
		{
			return "0";
		}
		return Common.smethod_10((Environment.TickCount - Int32_0) / 1000);
	}

	[CompilerGenerated]
	private void method_2()
	{
		try
		{
			while (Environment.TickCount - Int32_0 < Int32_1 * 1000 && Thread_0.IsAlive)
			{
				Thread.Sleep(1000);
			}
			Thread_0.Abort();
			while (Thread_0.IsAlive)
			{
				Thread.Sleep(1000);
			}
		}
		catch (Exception)
		{
		}
	}
}
