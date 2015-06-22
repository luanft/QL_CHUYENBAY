using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.DataAccessLayer
{
    class TraCuuLichBayDAL
    {
        DataConnection dataCon = DataConnection.getInstance();

        public DataTable LayTatCaChuyenBay()
        {
            return null;
        }
        public DataTable LayDanhSachMaChuyenBay()
        {
            return dataCon.Read("select MaChuyenBay from CHUYENBAY");  
        }
        public DataTable LayDanhSachTenSanBayDi(string MaTuyenBay)
        {
            return dataCon.Read("select SANBAY.TenSanBay from TUYENBAY join SANBAY on TUYENBAY.MaSanBayDi=SANBAY.MaSanBay where MaTuyenBay= '" + MaTuyenBay + "'");
        }
        public DataTable LayDanhSachTenSanBayDen(string MaTuyenBay)
        {
            return dataCon.Read("select SANBAY.TenSanBay from TUYENBAY join SANBAY on TUYENBAY.MaSanBayDen=SANBAY.MaSanBay where MaTuyenBay= '" + MaTuyenBay + "'");
        }
        public DataTable LayDanhSachSanBay()
        {
            return dataCon.Read("select MaSanBay, TenSanBay from SANBAY");
        }
        public DataTable LayDanhSachChuyenBay()
        {
            return dataCon.Read("select CHUYENBAY.MaChuyenBay, SB2.TenSanBay as TenSanBayDi, SB1.TenSanBay as TenSanBayDen, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh," + 
            "sum(LOAIGHE.SoGheDat) as TongSoGheDat, sum(SoGheTrong) as TongSoGheTrong from CHUYENBAY "+
            "join LOAIGHE on CHUYENBAY.MaChuyenBay= LOAIGHE.MaChuyenBay join TUYENBAY on TUYENBAY.MaTuyenBay = CHUYENBAY.MaTuyenBay "+ 
            "join SANBAY SB1 on SB1.MaSanBay= TUYENBAY.MaSanBayDen "+
            "join SANBAY SB2 on SB2.MaSanBay= TUYENBAY.MaSanBayDi group by CHUYENBAY.MaChuyenBay, SB1.TenSanBay, SB2.TenSanBay, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh");
        }
        public DataTable LayChuyenBay(string MaChuyenBay)
        {
            return dataCon.Read("select CHUYENBAY.MaChuyenBay, SB2.TenSanBay as TenSanBayDi, SB1.TenSanBay as TenSanBayDen, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh," + 
            "sum(LOAIGHE.SoGheDat) as TongSoGheDat, sum(SoGheTrong) as TongSoGheTrong from CHUYENBAY "+
            "join LOAIGHE on CHUYENBAY.MaChuyenBay= LOAIGHE.MaChuyenBay join TUYENBAY on TUYENBAY.MaTuyenBay = CHUYENBAY.MaTuyenBay "+ 
            "join SANBAY SB1 on SB1.MaSanBay= TUYENBAY.MaSanBayDen "+
            "join SANBAY SB2 on SB2.MaSanBay= TUYENBAY.MaSanBayDi  where CHUYENBAY.MaChuyenBay= '"+MaChuyenBay+"' group by CHUYENBAY.MaChuyenBay, SB1.TenSanBay, SB2.TenSanBay, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh");

        }
        public DataTable LayChuyenBay_theoSBdi(string TenSanBayDi)
        {
            return dataCon.Read("select CHUYENBAY.MaChuyenBay, SB1.TenSanBay as TenSanBayDi, SB2.TenSanBay as TenSanBayDen, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh," +
            "sum(LOAIGHE.SoGheDat) as TongSoGheDat, sum(SoGheTrong) as TongSoGheTrong from CHUYENBAY " +
            "join LOAIGHE on CHUYENBAY.MaChuyenBay= LOAIGHE.MaChuyenBay join TUYENBAY on TUYENBAY.MaTuyenBay = CHUYENBAY.MaTuyenBay " +
            "join SANBAY SB1 on SB1.MaSanBay= TUYENBAY.MaSanBayDi " +
            "join SANBAY SB2 on SB2.MaSanBay= TUYENBAY.MaSanBayDen  where SB1.TenSanBay = N'" + TenSanBayDi + "' group by CHUYENBAY.MaChuyenBay, SB1.TenSanBay, SB2.TenSanBay, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh");
        }
        public DataTable LayChuyenBay_theoSBden(string TenSanBayDen)
        {
            return dataCon.Read("select CHUYENBAY.MaChuyenBay, SB1.TenSanBay as TenSanBayDi, SB2.TenSanBay as TenSanBayDen, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh," +
            "sum(LOAIGHE.SoGheDat) as TongSoGheDat, sum(SoGheTrong) as TongSoGheTrong from CHUYENBAY " +
            "join LOAIGHE on CHUYENBAY.MaChuyenBay= LOAIGHE.MaChuyenBay join TUYENBAY on TUYENBAY.MaTuyenBay = CHUYENBAY.MaTuyenBay " +
            "join SANBAY SB1 on SB1.MaSanBay= TUYENBAY.MaSanBayDi " +
            "join SANBAY SB2 on SB2.MaSanBay= TUYENBAY.MaSanBayDen  where SB2.TenSanBay = N'" + TenSanBayDen + "' group by CHUYENBAY.MaChuyenBay, SB1.TenSanBay, SB2.TenSanBay, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh");
        }
        public DataTable LayChuyenBay_theoNgay(string tuNgay, string denNgay)
        {
            return dataCon.Read("select CHUYENBAY.MaChuyenBay, SB1.TenSanBay as TenSanBayDi, SB2.TenSanBay as TenSanBayDen, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh," +
           "sum(LOAIGHE.SoGheDat) as TongSoGheDat, sum(SoGheTrong) as TongSoGheTrong from CHUYENBAY " +
           "join LOAIGHE on CHUYENBAY.MaChuyenBay= LOAIGHE.MaChuyenBay join TUYENBAY on TUYENBAY.MaTuyenBay = CHUYENBAY.MaTuyenBay " +
           "join SANBAY SB1 on SB1.MaSanBay= TUYENBAY.MaSanBayDi " +
           "join SANBAY SB2 on SB2.MaSanBay= TUYENBAY.MaSanBayDen  where NgayKhoiHanh between convert(varchar,'" + tuNgay + "',103) and convert(varchar,'"+denNgay+"',103) group by CHUYENBAY.MaChuyenBay, SB1.TenSanBay, SB2.TenSanBay, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh");
        }
        public DataTable LayChuyenBay_theoSBdenvadi(string TenSanBayDi, string TenSanBayDen)
        {
            return dataCon.Read("select CHUYENBAY.MaChuyenBay, SB1.TenSanBay as TenSanBayDi, SB2.TenSanBay as TenSanBayDen, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh," +
            "sum(LOAIGHE.SoGheDat) as TongSoGheDat, sum(SoGheTrong) as TongSoGheTrong from CHUYENBAY " +
            "join LOAIGHE on CHUYENBAY.MaChuyenBay= LOAIGHE.MaChuyenBay "+
            "join TUYENBAY on TUYENBAY.MaTuyenBay = CHUYENBAY.MaTuyenBay "+
            "join SANBAY SB1 on SB1.MaSanBay= TUYENBAY.MaSanBayDi " +
            "join SANBAY SB2 on SB2.MaSanBay= TUYENBAY.MaSanBayDen "+
            "where SB2.TenSanBay = N'" + TenSanBayDen + "' and SB1.TenSanBay= N'"+TenSanBayDi+"' "+
            "group by CHUYENBAY.MaChuyenBay, SB1.TenSanBay, SB2.TenSanBay, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh");
        }
        public DataTable LayChuyenBay_theoSBden_NgayKhoiHanh(string TenSanBayDen, string tuNgay, string denNgay)
        {
            return dataCon.Read("select CHUYENBAY.MaChuyenBay, SB1.TenSanBay as TenSanBayDi, SB2.TenSanBay as TenSanBayDen, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh," +
          "sum(LOAIGHE.SoGheDat) as TongSoGheDat, sum(SoGheTrong) as TongSoGheTrong from CHUYENBAY " +
          "join LOAIGHE on CHUYENBAY.MaChuyenBay= LOAIGHE.MaChuyenBay join TUYENBAY on TUYENBAY.MaTuyenBay = CHUYENBAY.MaTuyenBay " +
          "join SANBAY SB1 on SB1.MaSanBay= TUYENBAY.MaSanBayDi " +
          "join SANBAY SB2 on SB2.MaSanBay= TUYENBAY.MaSanBayDen "+
          "where NgayKhoiHanh between convert(varchar,'" + tuNgay + "',103) and convert(varchar,'" + denNgay + "',103) and SB2.TenSanBay=N'"+TenSanBayDen+"' "+
          "group by CHUYENBAY.MaChuyenBay, SB1.TenSanBay, SB2.TenSanBay, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh");
        }
        public DataTable LayTongSoGheDat(string MaChuyenBay)
        {
            return dataCon.Read("select sum(SoGheDat) from CHUYENBAY join LOAIGHE on CHUYENBAY.MaChuyenBay=LOAIGHE.MaChuyenBay where CHUYENBAY.MaChuyenBay="+MaChuyenBay);
        }
        public DataTable LayTongSoGheTrong(string MaChuyenBay)
        {
            return dataCon.Read("select sum(SoGheTrong) from CHUYENBAY join LOAIGHE on CHUYENBAY.MaChuyenBay=LOAIGHE.MaChuyenBay where CHUYENBAY.MaChuyenBay=" + MaChuyenBay);
        }
    }
}