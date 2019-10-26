using QuanLySieuThi_Version2.GUIs.Manager;
using System;
using System.Windows.Forms;

namespace QuanLySieuThi_Version2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProductTypeForm());
            Application.Run(new ProductForm());
            
        }
    }
}
