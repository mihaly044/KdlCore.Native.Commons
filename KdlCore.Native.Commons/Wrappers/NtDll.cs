using KdlCore.Native.Commons.Win32Types;
using System;
using System.Runtime.InteropServices;

namespace KdlCore.Native.Commons.Wrappers
{
    internal class NtDll
    {
        [DllImport("ntdll.dll")]
        internal static extern NtStatus NtQuerySystemInformation(
            [In] SystemInformationClass systemInformationClass,
            IntPtr systemInformation,
            [In] int systemInformationLength,
            // ReSharper disable once OptionalParameterRefOut
            [Out][Optional] out int returnLength
        );
    }
}
