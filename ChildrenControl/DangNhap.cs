using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ChildrenControl
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            List<Account> accounts = new List<Account>();
            string pathtext = @"password.txt";
            string[] lines = File.ReadAllLines(pathtext);

            foreach (var line in lines)
            {
                string[] entries = line.Split(' ');
                Account newaccount = new Account();
                newaccount.Password = entries[0];
                newaccount.User = entries[1];
                accounts.Add(newaccount);
            }

            for (int i = 0; i < accounts.Count; i++)
            {
                if (textBoxMatKhau.Text == accounts[i].Password)
                {
                    if (accounts[i].User == "Parent")
                    {
                        MessageBox.Show("Đăng nhập bằng tài khoản phụ huynh, 60 phút sau tiến hành đăng nhập lại.");
                        this.Hide();
                        Thread parentthread = new Thread(ParentThread);
                        parentthread.Start();
                        this.Close();
                    }
                    else
                    {

                        //Shutdown();

                    }
                    break;
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập vào sai.");
                }
            }

        }

        static void ParentThread()
        {
            Thread.Sleep(TimeSpan.FromMinutes(60));
            DangNhap formDangNhap = new DangNhap();
            formDangNhap.ShowDialog();
        }



        static void Shutdown()
        {
            Process process = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "cmd.exe";
            processStartInfo.Arguments = @"/c shutdown -s -t 15";
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo = processStartInfo;
            process.Start();
            MessageBox.Show("Tắt máy sau 15 giây.");
        }

        private void buttonTaoTK_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan formTaoTK = new TaoTaiKhoan();
            formTaoTK.ShowDialog();
        }
    }
}
