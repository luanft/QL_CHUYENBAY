using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MainForm.DataAccessLayer;

namespace MainForm.BusinessLogicLayer
{
    class HeThongBLL
    {
        
        HeThongDAL dal = new HeThongDAL();
        public DataTable DanhSachChucNangHeThong()
        {
            return dal.LayDanhSachCacChucNang();
        }

        public DataTable NhomChucNang(string nhomNguoiDung)
        {
            return dal.NhomChucNang(nhomNguoiDung);
        }

        public DataTable DanhSachNhomNguoiDung()
        {
            return dal.LayDanhSachNhomNguoiDung();
        }

        public bool CheckLogin(string username, string password)
        {
            //kiem tra dang nhap
            return dal.GetLogin(username, password).Rows.Count > 0;                       
        }

        public DataTable GetUserRoles(string username)
        {
            return dal.GetUserRoles(username);
        }

        public void ThemQuyen(string chucNang, string nhom)
        {
            dal.ThemQuyen(chucNang, nhom);
        }

        public void XoaQuyen(string chucNang, string nhom)
        {
            dal.XoaQuyen(chucNang, nhom);
        }

        public string TaoMaNhanVienTiepTheo()
        {
            DataTable dt = dal.TongSoNhanVien();
            string tongSo = dt.Rows[0]["TongSo"].ToString();
            int current = int.Parse(tongSo);
            tongSo = (current + 1).ToString();
            string next_id = "NV";
            for (int i = tongSo.Length; i < 8; i++)
            {
                next_id += "0";
            }
            next_id += tongSo;
            return next_id;
        }

        public void ThemNhanVien(string id, string name, string pass, string email)
        {
            dal.ThemNguoiDung(id, name, pass, email);
        }

        public void ThemChucVuChoNhanVien(string maNhanVien, string chucVu)
        {
            try
            {
                dal.ThemChucVuChoNhanVien(maNhanVien, chucVu);
            }
            catch (Exception e)
            {

            }
            
        }

        public void XoaChucVuNhanVien(string maNhanVien, string chucVu)
        {
            dal.XoaChucVuNhanVien(maNhanVien, chucVu);
        }

        public DataTable LayCacChucVuNhanVien(string maNhanVien)
        {
            return dal.LayCacChucVuCuaNhanVien(maNhanVien);
        }

        public bool KiemTraSuTonTaiNguoiDung(string maNhanVien)
        {
            return dal.LayThongTinNguoiDung(maNhanVien).Rows.Count > 0;
        }
    }
}
