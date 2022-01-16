using System;
using System.IO;
using System.Windows.Forms;

namespace ChildrenControl
{
    public partial class TaoTaiKhoan : Form
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void buttonTaoTK_Click(object sender, EventArgs e)
        {
            if (textBoxMatKhau.Text == "")
            {
                MessageBox.Show("Thông tin mật khẩu bị thiếu.");
            }
            else if (comboBoxNguoiDung.Text == "")
            {
                MessageBox.Show("Thông tin loại tài khoản bị thiếu.");
            }         
            else
            {
                string pathtext = @"password.txt";
                if (File.Exists(pathtext) == true)
                {
                    File.AppendAllText(pathtext, textBoxMatKhau.Text + " " + comboBoxNguoiDung.Text + "\r\n");
                }
                else
                {
                    File.WriteAllText(pathtext, textBoxMatKhau.Text + " " + comboBoxNguoiDung.Text + "\r\n");
                }
                MessageBox.Show("Tạo thành công.");

                textBoxMatKhau.Text = null;
                comboBoxNguoiDung.Text = null;
            }
        }
    }
}
