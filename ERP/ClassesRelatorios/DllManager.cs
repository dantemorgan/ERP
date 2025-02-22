using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Loader;

namespace ERP.ClassesRelatorios
{
    public class DllManager
    {
        public static void ConfigurarDll()
        {
            var context = new CustomAssemblyLoadContext();
            context.LoadUnmanagedDll("libwkhtmltox");
        }
    }

    public class CustomAssemblyLoadContext : AssemblyLoadContext
    {
        public new IntPtr LoadUnmanagedDll(string unmanagedDllName)
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "DLL", "libwkhtmltox.dll");
            return LoadUnmanagedDllFromPath(fullPath);
        }
    }


}
