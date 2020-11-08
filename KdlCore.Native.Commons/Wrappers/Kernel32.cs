using System.Runtime.InteropServices;

namespace KdlCore.Native.Commons.Wrappers
{
    internal class Kernel32
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetDllDirectory(string lpPathName);
    }
}
