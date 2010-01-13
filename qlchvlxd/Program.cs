using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace qlchvlxd
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //public ManHinhChinhPL mainForm = new ManHinhChinhPL();
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DangNhap());
        }
    }
}
