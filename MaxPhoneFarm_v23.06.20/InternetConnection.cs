using System.Runtime.InteropServices;

internal class InternetConnection
{
	[DllImport("wininet.dll")]
	private static extern bool InternetGetConnectedState(out int int_0, int int_1);

	public static bool C41C7284()
	{
		int int_;
		return InternetGetConnectedState(out int_, 0);
	}
}
