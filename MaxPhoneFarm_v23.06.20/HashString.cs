using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[CompilerGenerated]
internal sealed class HashString
{
	internal static uint DA8CEBAB(string s)
	{
        uint num = 0u;
        if (s != null)
        {
            num = 2166136261u;
            for (int i = 0; i < s.Length; i++)
            {
                num = (s[i] ^ num) * 16777619;
            }
        }
        return num;
    }
}
