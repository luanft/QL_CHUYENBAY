using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.DataAccessLayer
{
    class TraVeDAL
    {
        DataConnection _connect = DataConnection.getInstance();
        public TraVeDAL()
        {

        }
        public DataTable lay_danh_sach_ma_ve()
        {
            string connectstring = @"Select MaVe
                                    from VE 
                                    where DaLayVe=1";

            return _connect.Read(connectstring);
        }
        public DataTable lay_danh_sach_ve()
        {
            string connectstring = @"Select v.MaPhieuDat,v.MaVe,cb.MaChuyenBay,v.HanhKhach,v.CMND,v.DienThoai,v.HangVe,hv.TenHangVe,v.GiaTien
                                    from  VE v
                                    inner join CHUYENBAY cb ON cb.MaChuyenBay=v.MaChuyenBay
                                    inner join TUYENBAY tb ON tb.MaTuyenBay=cb.MaTuyenBay
                                    inner join HANGVE hv ON hv.MahangVe=v.HangVe
                                    where v.DaLayVe=1";
            return _connect.Read(connectstring);
        }
        public string lay_thong_tin_SB_di(string macb)
        {
            string connectstring1 = @"Select  tb.MaSanBayDi
                                    from  TUYENBAY tb
                                    inner join CHUYENBAY cb ON cb.MaTuyenBay=tb.MaTuyenBay
                                    where cb.MaChuyenBay ='" + macb + "'";
            string connectstring = @"Select sb.TenSanBay
                                     From SANBAY sb
                                     where sb.MaSanBay IN(" + connectstring1 + ")";
            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_thong_tin_SB_den(string macb)
        {
            string connectstring1 = @"Select  tb.MaSanBayDen
                                    from  TUYENBAY tb
                                    inner join CHUYENBAY cb ON cb.MaTuyenBay=tb.MaTuyenBay
                                    where cb.MaChuyenBay ='" + macb + "'";
            string connectstring = @"Select sb.TenSanBay
                                     From SANBAY sb
                                     where sb.MaSanBay IN(" + connectstring1 + ")";
            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_thoi_gian_bay(string macb)
        {
            string connectstring = @"Select  cb.ThoiGianBay
                                    from  CHUYENBAY cb
                                    where cb.MaChuyenBay ='" + macb + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_ngay_khoi_hanh(string macb)
        {
            string connectstring = @"Select  cb.NgayKhoiHanh
                                    from  CHUYENBAY cb
                                    where cb.MaChuyenBay ='" + macb + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_gio_khoi_hanh(string macb)
        {
            string connectstring = @"Select  cb.GioKhoiHanh
                                    from  CHUYENBAY cb
                                    where cb.MaChuyenBay ='" + macb + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public DataTable lay_danh_sach_SBTG(string macb)
        {
            string connectstring = @"Select  sb.TenSanBay,sb.DiaChi,sbtg.ThoiGianDUng,sbtg.GhiChu
                                    from  SANBAYTRUNGGIAN sbtg
                                    inner join SANBAY sb ON sb.MaSanBay=sbtg.MaSanBay
                                    where sbtg.MaChuyenBay ='" + macb + "'";
            return _connect.Read(connectstring);
        }
        public string lay_ten_hang_ve(string mahv)
        {
            string connectstring = @"Select  hv.TenHangVe
                                    from  HANGVE hv
                                    where hv.MaHangVe ='" + mahv + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_gia_hang_ve(string macb, string mahv)
        {
            string connectstring1 = @"Select  cb.DonGia
                                    from  CHUYENBAY cb
                                    where cb.MaChuyenBay ='" + macb + "'";
            int don_gia = int.Parse(_connect.Read(connectstring1).Rows[0].ItemArray[0].ToString());
            string connectstring2 = @"Select  hv.TiLeDonGia
                                    from  HANGVE hv
                                    where hv.MaHangVe ='" + mahv + "'";
            int ti_le_don_gia = int.Parse(_connect.Read(connectstring2).Rows[0].ItemArray[0].ToString());

            return (don_gia * ti_le_don_gia).ToString();
        }
        public string lay_macb(string mav)
        {
            string connectstring = @"Select  v.MaChuyenBay
                                    from  VE v
                                    where v.MaVe ='" + mav + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_tenhk(string mav)
        {
            string connectstring = @"Select  v.HanhKhach
                                    from  VE v
                                    where v.MaVe ='" + mav + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_cmnd(string mav)
        {
            string connectstring = @"Select  v.CMND
                                    from  VE v
                                    where v.MaVe ='" + mav + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_sdt(string mav)
        {
            string connectstring = @"Select  v.DienThoai
                                    from  VE v
                                    where v.MaVe ='" + mav + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_mahangve(string mav)
        {
            string connectstring = @"Select  v.HangVe
                                    from  VE v
                                    where v.MaVe ='" + mav + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_giatien(string mav)
        {
            string connectstring = @"Select  v.GiaTien
                                    from  VE v
                                    where v.MaVe ='" + mav + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public void xoa(string mav)
        {
            string connectstring = @" UPDATE VE SET DaLayVe=N'2'where  MaVe =N'" + mav + "'";
            _connect.Write(connectstring);
        }
        public string lay_mpd(string mav)
        {
            string connectstring = @"Select  v.MaPhieuDat
                                    from  VE v
                                    where v.MaVe ='" + mav + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public void xoa_pd(string mapd)
        {
            string connectstring = @" UPDATE PHIEUDATCHO SET Huy=N'1'where  MaPhieuDat =N'" + mapd + "'";
            _connect.Write(connectstring);
        }
        public int lay_so_ghe_trong(string macb, string mahv)
        {
            string connectstring = @"Select  lg.SoGheTrong
                                    from  LOAIGHE lg
                                    where lg.MaChuyenBay ='" + macb + "' and lg.MaHangVe='" + mahv + "'";

            return int.Parse(_connect.Read(connectstring).Rows[0].ItemArray[0].ToString());
        }
        public void cap_nhat_so_ghe_trong(string macb, string mahv, int soluong)
        {
            string connectstring = @" UPDATE LOAIGHE SET SoGheTrong=N'" + soluong + "'where  MaChuyenBay =N'" + macb + "' and MaHangVe='" + mahv + "'";
            _connect.Write(connectstring);
        }
        public int lay_so_ghe_da_dat(string macb, string mahv)
        {
            string connectstring = @"Select  lg.SoGheDat
                                    from  LOAIGHE lg
                                    where lg.MaChuyenBay ='" + macb + "' and lg.MaHangVe='" + mahv + "'";

            return int.Parse(_connect.Read(connectstring).Rows[0].ItemArray[0].ToString());
        }
        public void cap_nhat_so_ghe_da_dat(string macb, string mahv, int soluong)
        {
            string connectstring = @" UPDATE LOAIGHE SET SoGheDat=N'" + soluong + "'where  MaChuyenBay =N'" + macb + "' and MaHangVe='" + mahv + "'";
            _connect.Write(connectstring);
        }


    }
}
