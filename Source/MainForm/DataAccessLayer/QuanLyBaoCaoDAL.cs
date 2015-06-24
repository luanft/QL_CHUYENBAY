using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.DataAccessLayer
{

    class QuanLyBaoCaoDAL
    {
        DataConnection conn = DataConnection.getInstance();

        public DataTable LayChuyenBay(int thang, int nam)
        {
            string sql = "select * from CHUYENBAY where MONTH(NgayKhoiHanh) = " + thang + "and YEAR(NgayKhoiHanh) = " + nam;
            DataTable tmp = conn.Read(sql);
            return tmp;
        }

        public DataTable LayDoanhThuThang(int nam)
        {
            string sql = "select * from DOANHTHUTHANG where Nam = " + nam;
            DataTable tmp = conn.Read(sql);
            return tmp;
        }

        public DataTable LayHangVe()
        {
            string sql = "select * from HANGVE";
            DataTable tmp = conn.Read(sql);
            return tmp;
        }

        public DataTable LayLoaiGhe(string macb)//, string mahv)
        {
            string sql = "select * from LOAIGHE where MaChuyenBay = '" + macb ;//+ "'and MaHangVe = '" + mahv + "'";
            DataTable tmp = conn.Read(sql);
            return tmp;
        }

        public DataTable LayChuyenBay(int nam)
        {
            string sql = "select * from CHUYENBAY where  YEAR(NgayKhoiHanh) = " + nam;
            DataTable tmp = conn.Read(sql);
            return tmp;
        }

        public DataTable LayLoaiGheTheoHangVe(string macb, string mahv)
        {
            string sql = "select SoGhe,SoGheDat,SoGheTrong,TenHangVe,TiLeDonGia from LOAIGHE,HANGVE where MaChuyenBay = '" + macb + "'and MaHangVe = '" + mahv + "' and LOAIGHE.MaHangVe = HANGVE.MaHangVe";
            DataTable tmp = conn.Read(sql);
            return tmp;
        }

        public void LuuDoanhThuThang(string thang, string nam, string sochuyenbay, string doanhthu)
        {
            string sql = "insert into DOANHTHUTHANG values('" + thang + "','" + nam + "','" + sochuyenbay + "','" + doanhthu + "',null";
            conn.Write(sql);
        }

        public void UpdateDTT(string thang,string nam, string sochuyenbay, string doanhthu)
        {
            string sql = "update DOANHTHUTHANG set SoChuyenBay='" + sochuyenbay + "',DoanhThu='" + doanhthu + "' where Thang='" + thang + "' and Nam='" + nam + "'";
            conn.Write(sql);
        }

        public void LuuDoanhThuNam(string nam, string doanhthunam)
        {
            string sql = "insert into DOANHTHUNAM values('" + nam + "','" + doanhthunam + "')";
             conn.Write(sql);
        }

        public void UpdateDTN(string nam, string doanhthunam)
        {
            string sql = "update DOANHTHUNAM set DoanhThuNam ='" + doanhthunam + "' where Nam='" + nam + "'";
            conn.Write(sql);
        }

        public DataTable LayNamThang()
        {
            string sql = "select distinct YEAR(NgayKhoiHanh) as Year from CHUYENBAY";
            DataTable tmp = conn.Read(sql);
            return tmp;
        }

        public DataTable LayThang(string nam)
        {
            string sql = "select MONTH(NgayKhoiHanh) as Month from CHUYENBAY where YEAR(NgayKhoiHanh)=" + nam + "";
            DataTable tmp = conn.Read(sql);
            return tmp;
        }

        public DataTable LayNam()
        {
            string sql = "select distinct Nam from DOANHTHUTHANG";
            DataTable tmp = conn.Read(sql);
            return tmp;
        }
    }
}
