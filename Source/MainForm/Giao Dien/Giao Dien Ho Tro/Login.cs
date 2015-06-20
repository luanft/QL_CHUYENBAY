using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForm.BusinessLogicLayer;

namespace MainForm.Giao_diện.Giao_Diện_Hỗ_Trợ
{
    public partial class Login : Form
    {
        HeThongBLL bll = new HeThongBLL();
        public bool IsLogged
        {
            get;
            set;
        }
        public Login()
        {
            InitializeComponent();
            IsLogged = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                lb_notify.Text = "* Bạn chưa nhập tên đăng nhập!";
                return;
            }
            if (txt_password.Text == "")
            {
                lb_notify.Text = "* Bạn chưa nhập mật khẩu!";
                return;
            }
            if (bll.CheckLogin(txt_username.Text, txt_password.Text))
            {
                LoginController.GetInstance().SetLogin(txt_username.Text);
                IsLogged = true;                
                this.Close();
            }
            else
            {
                lb_notify.Text = "* Tên truy cập hoặc mật khẩu không đúng!";
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_username.Text == "")
                {
                    lb_notify.Text = "* Bạn chưa nhập tên đăng nhập!";
                    return;
                }
                if (txt_password.Text == "")
                {
                    lb_notify.Text = "* Bạn chưa nhập mật khẩu!";
                    return;
                }
                if (bll.CheckLogin(txt_username.Text, txt_password.Text))
                {
                    LoginController.GetInstance().SetLogin(txt_username.Text);
                    IsLogged = true;
                    this.Close();
                }
                else
                {
                    lb_notify.Text = "* Tên truy cập hoặc mật khẩu không đúng!";
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
