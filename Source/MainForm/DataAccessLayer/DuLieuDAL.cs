using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.DataAccessLayer
{
    class DuLieuDAL
    {
        DataConnection conn = DataConnection.getInstance();
        public DataTable LayDanhSachNhanVien()
        {
            return conn.Read("Select* from NHANVIEN");
        }
        public DataTable LayDanhSachNhomNguoiDung()
        {
            return conn.Read("Select * from NHOMNGUOIDUNG");
        }
        public DataTable LayDanhSachTuyenBay()
        {
            return conn.Read("Select * from TUYENBAY");
        }
        public DataTable LayDanhSachPhieuDatCho()
        {
            return conn.Read("Select * from PHIEUDATCHO");
        }
        public DataTable LayDanhSachVe()
        {
            return conn.Read("Select * from VE");
        }
        public DataTable LayDanhSachQuyenHan()
        {
            return conn.Read("Select * from QUYENHAN");
        }
        public DataTable LayDanhSachSanBay()
        {
            return conn.Read("Select * from SANBAY");
        }
        public DataTable LayDanhSachHangVe()
        {
            return conn.Read("Select * from HANGVE");
        }
        public DataTable LayDanhSachThamSo()
        {
            return conn.Read("Select * from THAMSO");
        }
     
    }
}
