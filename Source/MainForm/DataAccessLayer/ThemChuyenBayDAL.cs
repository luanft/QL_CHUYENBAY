using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.DataAccessLayer
{
    class ThemChuyenBayDAL
    {
        DataConnection dataCon = DataConnection.getInstance();

        public DataTable LayDanhSachMaTuyenBay()
        {
            return dataCon.Read("Select MaTuyenBay from TUYENBAY");
        }
        public DataTable LayMaChuyenBayCuoiBang()
        {
            return dataCon.Read("Select top 1 MaChuyenBay from CHUYENBAY order by MaChuyenBay DESC");
        }
        public DataTable LayDanhSachHangVe()
        {
            return dataCon.Read("select MaHangVe, TenHangVe from HANGVE");
        }
        public DataTable LayDanhSachTenSanBayTrungGian(string MaSanBayDen, string MaSanBayDi)
        {
            return dataCon.Read("select MaSanBay, TenSanBay from SANBAY where TenSanBay not in (N'"+MaSanBayDen+"',N'"+MaSanBayDi+"')");
        }
        public DataTable LayTenSanBayDi(string MaTuyenBay)
        {
            return dataCon.Read("select SANBAY.TenSanBay from TUYENBAY join SANBAY on TUYENBAY.MaSanBayDi=SANBAY.MaSanBay where MaTuyenBay= '" + MaTuyenBay+"'");
        }
         public DataTable LayTenSanBayDen(string MaTuyenBay)
        {
            return dataCon.Read("select SANBAY.TenSanBay from TUYENBAY join SANBAY on TUYENBAY.MaSanBayDen=SANBAY.MaSanBay where MaTuyenBay= '" + MaTuyenBay+"'");
        }
        public void ThemChuyenBay(string MaChuyenBay, string MaTuyenBay, int ThoiGianBay, double DonGia, string NgayKhoiHanh, string GioKhoiHanh)
        {
            dataCon.Write(" set dateformat dmy");
            dataCon.Write("insert  into CHUYENBAY  values('"+MaChuyenBay+"','"+MaTuyenBay+"',"+ThoiGianBay+","+DonGia+",'"+NgayKhoiHanh+"','"+GioKhoiHanh+"')");
        }
        public void ThemLoaiGhe(string MaChuyenBay, string MaHangVe, int SoGhe, int SoGheDat, int SoGheTrong)
        {
            dataCon.Write("insert into LOAIGHE values('"+MaChuyenBay+"','"+MaHangVe+"',"+SoGhe+","+SoGheDat+","+SoGheTrong+")");
        }
        public void ThemSanBayTrungGian(string MaChuyenBay, string MaSanBay, int ThoiGianDung, string GhiChu)
        {
            dataCon.Write("insert into SANBAYTRUNGGIAN values ('"+MaChuyenBay+"','"+MaSanBay+"',"+ThoiGianDung+",'"+GhiChu+"')");
        }
        public DataTable LayThamSo(string TenThamSo)
        {
            return dataCon.Read("select "+TenThamSo+" from THAMSO");
        }

    }
}
