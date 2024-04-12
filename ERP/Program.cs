using ERP.Forms;
using ERP.Services;
using System.Data.SqlClient;

namespace ERP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            
            Application.Run(new frmLogin());

        }
    }
}