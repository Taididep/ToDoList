using System;
using System.Windows.Forms;
using ToDoList.Client;

namespace ToDoList.Controller
{
    public class Controller
    {
        //  button login
        public void Login_Button_Click(object sender, EventArgs e, string username, string password, Form currentForm)
        {
            if (Login(username, password))
            {
                // Tạo instance của frm_Main
                frm_Main mainForm = new frm_Main();

                // Hiển thị frm_Main
                mainForm.Show();

                // Đóng form (frm_Login)
                currentForm.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Kiểm tra thông tin đăng nhập
        public bool Login(string username, string password)
        {
            if (username == "admin" && password == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
