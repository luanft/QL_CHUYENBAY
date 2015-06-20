using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MainForm.DataAccessLayer;
using System.Data;

namespace MainForm.DataAccessLayer
{
    
    class LayveDAL
    {
        DataConnection _connect = DataConnection.getInstance();
        public LayveDAL()
        {

        }
        public DataTable lay_danh_sach_ma_phieu_dat()
        {
            string connectstring = @"Select v.MaPhieuDat
                                    from VE v
                                    where v.DaLayVe='0' and v.MaPhieuDat IS NOT NULL";
            return _connect.Read(connectstring);

        }
        public DataTable lay_danh_sach_ma_CB()
        {
            string connectstring = @"Select cb.MaChuyenBay
                                    from CHUYENBAY cb ";
                                    
            return _connect.Read(connectstring);
        }
        public DataTable lay_danh_sach_ma_hang_ve(string machuyenbay)
        {
            string connectstring = @"Select lg.MaHangVe
                                    from LOAIGHE lg
                                    where lg.MaChuyenBay ='"+machuyenbay+"'";
            return _connect.Read(connectstring);
        }
        public string tong_so_luong_ve()
        {
            string connectstring = @"Select count(*)
                                    from VE
                                    ";
            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_thong_tin_SB_di(string macb)
        {
            string connectstring1 = @"Select  tb.MaSanBayDi
                                    from  TUYENBAY tb
                                    inner join CHUYENBAY cb ON cb.MaTuyenBay=tb.MaTuyenBay
                                    where cb.MaChuyenBay ='" + macb + "'";
            string connectstring = @"Select sb.TenSanBay
                                     From SANBAY sb
                                     where sb.MaSanBay IN("+connectstring1+")";
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
        public void luu_ve_moi_chua_dat(string mave, string mcb, string tenhk, string cmnd, string sdt, string mahv, string dalay, string giatien)
        {
            string connectstring = " Insert INTO VE VALUES (N'" + mave + "',N'" + mcb + "',N'" + tenhk + "',N'" + cmnd + "',N'" + sdt + "',N'" + mahv + "',N'" + dalay + "',N'" + giatien+"',null)";
            _connect.Write(connectstring);
        }
        public int lay_so_ghe_trong(string macb,string mahv)
        {
            string connectstring = @"Select  lg.SoGheTrong
                                    from  LOAIGHE lg
                                    where lg.MaChuyenBay ='" + macb + "' and lg.MaHangVe='"+mahv+"'";

            return int.Parse(_connect.Read(connectstring).Rows[0].ItemArray[0].ToString());
        }
        public void cap_nhat_so_ghe_trong(string macb,string mahv,int soluong)
        {
            string connectstring = @" UPDATE LOAIGHE SET SoGheTrong=N'" + soluong + "'where  MaChuyenBay =N'" + macb + "' and MaHangVe='"+mahv+"'";
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
        public string lay_ma_cb(string mav)
        {
            string connectstring = @"Select  v.MaChuyenBay
                                    from  VE v
                                    where v.MaVe ='" + mav + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_ma_hang_ve(string mav)
        {
            string connectstring = @"Select  v.HangVe
                                    from  VE v
                                    where v.MaVe ='" + mav + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public DataTable lay_danh_sach_ve_khong_dat_truoc()
        {
            string connectstring = @"Select v.MaPhieuDat,v.MaVe,cb.MaChuyenBay,v.HanhKhach,v.CMND,v.DienThoai,v.HangVe,hv.TenHangVe,v.GiaTien
                                    from  VE v
                                    inner join CHUYENBAY cb ON cb.MaChuyenBay=v.MaChuyenBay
                                    inner join TUYENBAY tb ON tb.MaTuyenBay=cb.MaTuyenBay
                                    inner join HANGVE hv ON hv.MahangVe=v.HangVe
                                    where v.DaLayVe=1 and v.MaPhieuDat IS NULL";
            return _connect.Read(connectstring);
        }
        public DataTable lay_danh_sach_ve_da_dat_truoc()
        {
            string connectstring = @"Select v.MaPhieuDat,v.MaVe,cb.MaChuyenBay,v.HanhKhach,v.CMND,v.DienThoai,v.HangVe,hv.TenHangVe,v.GiaTien
                                    from  VE v
                                    inner join CHUYENBAY cb ON cb.MaChuyenBay=v.MaChuyenBay
                                    inner join TUYENBAY tb ON tb.MaTuyenBay=cb.MaTuyenBay
                                    inner join HANGVE hv ON hv.MahangVe=v.HangVe
                                    where v.DaLayVe=1 and v.MaPhieuDat IS NOT NULL";
            return _connect.Read(connectstring);
        }
        public string lay_thong_tin_ma_ve_da_dat(string mapd)
        {
            string connectstring = @"Select  v.MaVe
                                    from  VE v
                                    where v.MaPhieuDat ='" + mapd + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_thong_tin_ma_cb_da_dat(string mapd)
        {
            string connectstring = @"Select  v.MaChuyenBay
                                    from  VE v
                                    where v.MaPhieuDat ='" + mapd + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_thong_tin_te_kh_da_dat(string mapd)
        {
            string connectstring = @"Select  v.HanhKhach
                                    from  VE v
                                    where v.MaPhieuDat ='" + mapd + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_thong_tin_cmnd_da_dat(string mapd)
        {
            string connectstring = @"Select  v.CMND
                                    from  VE v
                                    where v.MaPhieuDat ='" + mapd + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_thong_tin_sdt_da_dat(string mapd)
        {
            string connectstring = @"Select  v.DienThoai
                                    from  VE v
                                    where v.MaPhieuDat ='" + mapd + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string lay_thong_tin_hang_ve_da_dat(string mapd)
        {
            string connectstring = @"Select  v.HangVe
                                    from  VE v
                                    where v.MaPhieuDat ='" + mapd + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public void luu_ve_da_dat(string mave,string tenhk, string sdt, string cmnd)
        {
            string connectstring = @" UPDATE VE SET DaLayVe='1', HanhKhach=N'"+tenhk+"', DienThoai=N'"+sdt+"',CMND=N'"+cmnd+"'where  MaVe =N'" + mave + "'";
            _connect.Write(connectstring);
        }
        public void cap_nhat_ve_khong_dat_truoc(string mapd, string mave, string mcb, string tenhk, string cmnd, string sdt, string mahv, string giatien)
        {
            string connectstring = @" UPDATE VE SET MaChuyenBay=N'"+mcb+"',HanhKhach=N'"+tenhk+"',CMND=N'"+cmnd+"',DienThoai=N'"+sdt+"',HangVe=N'"+mahv+"',GiaTien=N'"+giatien+"'where  MaVe =N'" + mave + "'";
            _connect.Write(connectstring);
        }
        public void cap_nhat_ve_dat_truoc( string mave, string tenhk, string cmnd, string sdt)
        {
            string connectstring = @" UPDATE VE SET HanhKhach=N'" + tenhk + "',CMND=N'" + cmnd + "',DienThoai=N'" + sdt + "'where  MaVe =N'" + mave + "'";
            _connect.Write(connectstring);
        }

        
    }
}
