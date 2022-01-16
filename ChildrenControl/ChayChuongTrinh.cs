using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace ChildrenControl
{
    public partial class ChayChuongTrinh : Form
    {
        public ChayChuongTrinh()
        {
            InitializeComponent();
        }

        private bool IsStartupItem()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rkApp.GetValue("ChildrenControl") == null)
                // The value doesn't exist, the application is not set to run at startup
                return false;
            else
                // The value exists, the application is set to run at startup
                return true;
        }

        private void ChayChuongTrinh_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAutorun_Click(object sender, EventArgs e)
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (!IsStartupItem())
            {
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("ChildrenControl", Application.ExecutablePath.ToString());
            }

            string pathtext = @"check.txt";
            string check = File.ReadAllText(pathtext);
            if (check == "false")
            {
                File.WriteAllText(pathtext, "true");
            }
            MessageBox.Show("Chạy thành công, chương trình sẽ chạy ở chế độ Autorun.");
            DangNhap formDangNhap = new DangNhap();
            this.Hide();
            formDangNhap.ShowDialog();
            this.Close();
        }
    }
}
