using class_Controls;
using System;
using System.Windows.Forms;
using ToDoList.Controller;

namespace ToDoList.Client
{
    public partial class frm_Login : Form
    {
        private Controller.Controller controller;
        public frm_Login()
        {
            InitializeComponent();
            controller = new Controller.Controller();  // Khởi tạo instance của Controller
        }


        //  button login
        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Gọi phương thức Login_Button_Click từ Controller
            controller.Login_Button_Click(sender, e, txt_UserName1.Text, txt_Password1.Text, this);
        }



    }
}
