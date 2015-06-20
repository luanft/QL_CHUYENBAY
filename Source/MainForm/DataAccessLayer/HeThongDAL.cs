using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.DataAccessLayer
{
    class HeThongDAL
    {
        //lay danh sach cac chuc nang trong he thong
        public DataTable LayDanhSachCacChucNang()
        {
            return DataConnection.getInstance().Read("select MaChucNang from CHUCNANG");            
        }

        //lay ten dang nhap ba mat khau
        public DataTable GetLogin(string userName, string password)
        {
            return DataConnection.getInstance().Read("select * from NHANVIEN where MaNhanVien = '" + userName + "' and MatKhau = '" + password+ "'");
        }

        //Lay cac quyen han cua nguoi dung
        public DataTable GetUserRoles(string username)
        {
            return DataConnection.getInstance().Read("select MaChucNang from NHOMCHUCNANG where MaNhomNguoiDung in (select MaNhomNguoiDung from QUYENHAN where MaNhanVien = '"+username+"')");
        }

        //lay danh sach cac nhom nguoi dung trong he thong
        public DataTable LayDanhSachNhomNguoiDung()
        {
            return DataConnection.getInstance().Read("select * from NHOMNGUOIDUNG");
        }

        //lay các chuc nang ma nhom nguoi dung duoc su dung
        public DataTable NhomChucNang(string nhomNguoiDung)
        {
            string sql = "select CHUCNANG.MaChucNang,CHUCNANG.MoTaChucNang, case when CHUCNANG_{0}.MaChucNang is not null then 'true' else 'false' end as UserRole  from CHUCNANG left join CHUCNANG_{0} on CHUCNANG.MaChucNang = CHUCNANG_{0}.MaChucNang";
            return DataConnection.getInstance().Read(string.Format(sql,nhomNguoiDung));
        }

        //Thêm quyên moi
        public void ThemQuyen(string maChucNang, string nhomNguoiDung)
        {
            string sql = "insert into NHOMCHUCNANG values('{0}','{1}')";
            DataConnection.getInstance().Write(string.Format(sql,nhomNguoiDung,maChucNang));
        }
        //Xoa quyen
        public void XoaQuyen(string maChucNang, string nhomNguoiDung)
        {
            string sql = "delete  from NHOMCHUCNANG where MaNhomNguoiDung = '{0}' and MaChucNang = '{1}'";
            DataConnection.getInstance().Write(string.Format(sql,nhomNguoiDung,maChucNang));
        }

        //them nguoi dung
        public void ThemNguoiDung(string id, string name, string pass,string email)
        {
            string sql = "insert into NHANVIEN values('{0}',N'{1}','{2}','{3}')";
            DataConnection.getInstance().Write(string.Format(sql, id, name, email, pass));
        }

        //dem so nhan vien he thong

        public DataTable TongSoNhanVien()
        {
            return DataConnection.getInstance().Read("select count(*) as TongSo from NHANVIEN");
        }

        //them quyen han cho nhan vien
        public void ThemChucVuChoNhanVien(string maNhanVien, string chucVu)
        {
            string sql = "insert into QUYENHAN values('{0}','{1}')";
            DataConnection.getInstance().Write(string.Format(sql, chucVu, maNhanVien));
        }

        //xoa chuc vu cua nhan vien
        public void XoaChucVuNhanVien(string maNhanVien, string chucVu)
        {
            string sql = "delete from QUYENHAN where MaNhanVien = '{0}' and MaNhomNguoiDung = '{1}'";
            DataConnection.getInstance().Write(string.Format(sql, maNhanVien, chucVu));
        }

        public DataTable LayCacChucVuCuaNhanVien(string maNhanVien)
        {
            string sql = "select NHOMNGUOIDUNG.MaNhomNguoiDung,case when QUYENHAN.MaNhomNguoiDung is not null then 'true' else 'false' end as HAVE,TenNhomNguoiDung from NHOMNGUOIDUNG left join QUYENHAN on NHOMNGUOIDUNG.MaNhomNguoiDung = QUYENHAN.MaNhomNguoiDung and QUYENHAN.MaNhanVien = '{0}'";
            return DataConnection.getInstance().Read(string.Format(sql, maNhanVien));
        }

        public DataTable LayThongTinNguoiDung(string maNhanVien)
        {
            string sql = "select * from NHANVIEN where MaNhanVien = '{0}'";
            return DataConnection.getInstance().Read(string.Format(sql, maNhanVien));
        }
    }
}
