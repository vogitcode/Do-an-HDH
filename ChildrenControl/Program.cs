using System;
using System.IO;
using System.Windows.Forms;

namespace ChildrenControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string pathtext = @"check.txt";
            string check = File.ReadAllText(pathtext);
            if (check == "false")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ChayChuongTrinh());
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new DangNhap());

            }
        }
    }
}
