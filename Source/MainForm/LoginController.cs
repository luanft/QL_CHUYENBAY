using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MainForm.BusinessLogicLayer;

namespace MainForm
{
    class LoginController
    {
        static LoginController _loginController;
        QuanLyQuyenHan _role;
        string full_name = "";
        string user_name = "";
        public static LoginController GetInstance()
        {
            if (_loginController == null)
                _loginController = new LoginController();
            return _loginController;
        }

        public static void Destroy()
        {
            _loginController = null;
        }
        private LoginController()
        {
            DataTable danhSachCacChucNang = dal.LayDanhSachCacChucNang();
            _role = new QuanLyQuyenHan(danhSachCacChucNang);
        }
        DataAccessLayer.HeThongDAL dal = new DataAccessLayer.HeThongDAL();

        public QuanLyQuyenHan GetRoles()
        {
            return _role;
        }
       

        public void SetLogin(string userName)
        {
            //luu lai nguoi dung vua dang nhap he thong
            user_name = userName;
            //lay danh sach cac chuc nang ma nguoi user duoc su dung
            LoadUserRole();
        }
        public void LoadUserRole()
        {
            DataTable danhSachChucNang = dal.GetUserRoles(user_name);
            foreach (DataRow i in danhSachChucNang.Rows)
            {
                _role.SetValue(i["MaChucNang"].ToString().Trim(), true);
            }
        }
    }
}
