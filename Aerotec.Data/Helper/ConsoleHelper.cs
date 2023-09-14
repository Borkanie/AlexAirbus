using System;
using System.Runtime.InteropServices;

namespace Aerotec.Data.Helper
{
    public class ConsoleHelper
    {
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
    }
}
