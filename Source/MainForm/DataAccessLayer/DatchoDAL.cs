using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.DataAccessLayer
{
    class DatchoDAL
    {
        DataConnection _connect = DataConnection.getInstance();
        public DatchoDAL()
        {

        }
        public DataTable lay_danh_sach_ma_CB()
        {
            string connectstring = @"Select cb.MaChuyenBay
                                    from CHUYENBAY cb where cb.GioKhoiHanh >'"+DateTime.Now+"'";

            return _connect.Read(connectstring);
        }
        public DataTable lay_danh_sach_ma_hang_ve(string machuyenbay)
        {
            string connectstring = @"Select lg.MaHangVe
                                    from LOAIGHE lg
                                    where lg.MaChuyenBay ='" + machuyenbay + "'";
            return _connect.Read(connectstring);
        }
        public string tong_so_luong_ve()
        {
            string connectstring = @"Select count(*)
                                    from VE
                                    ";
            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public string tong_so_luong_phieu_dat()
        {
            string connectstring = @"Select count(*)
                                    from PHIEUDATCHO
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
        public void luu_ve_(string mave, string mcb, string tenhk, string cmnd, string sdt, string mahv, string dalay, string giatien,string mapd)
        {
            string connectstring = " Insert INTO VE VALUES (N'" + mave + "',N'" + mcb + "',N'" + tenhk + "',N'" + cmnd + "',N'" + sdt + "',N'" + mahv + "',N'" + dalay + "',N'" + giatien + "',N'"+mapd+"')";
            _connect.Write(connectstring);
        }
        public void luu_phieu_dat(string mapdh, string ngay, string ten, string cmnd, string sdt, string huy)
        {
            string connectstring = " Insert INTO PHIEUDATCHO VALUES (N'" + mapdh + "',N'" + ngay + "',N'" + ten + "',N'" + cmnd + "',N'" + sdt + "',N'" + huy + "')";
            _connect.Write(connectstring);
        }
        public void cap_nhat_ve_(string mave, string mcb, string tenhk, string cmnd, string sdt, string mahv, string dalay, string giatien, string mapd)
        {
            string connectstring = @" UPDATE VE SET MaChuyenBay=N'" + mcb + "',HanhKhach=N'" + tenhk + "',CMND=N'" + cmnd + "',DienThoai=N'" + sdt + "',HangVe=N'" + mahv + "',GiaTien=N'" + giatien + "',MaPhieuDat=N'"+mapd+"'where  MaVe =N'" + mave + "'";
            _connect.Write(connectstring);
        }
        public void cap_nhat_phieu_dat(string mapdh, string ngay, string ten, string cmnd, string sdt, string huy)
        {
            string connectstring = @" UPDATE PHIEUDATCHO SET NgayDat=N'" + ngay + "',NguoiDat=N'" + ten + "',CMND=N'" + cmnd + "',DienThoai=N'" + sdt +"'where  MaPhieuDat =N'" + mapdh + "'";
            _connect.Write(connectstring);
        }
        public string lay_quy_dinh_han_chot_dat_ve()
        {
            string connectstring = @"Select  t.HangChotDatVe
                                    from  THAMSO t
                                   ";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
        }
        public DataTable lay_danh_sach_khi_load_form()
        {
            string connectstring = @"Select  pdc.MaPhieuDat,pdc.NguoiDat,pdc.CMND,pdc.DienThoai,v.MaChuyenBay,v.HangVe,v.MaVe,v.HanhKhach,v.CMND,v.DienThoai,v.GiaTien
                                    from  VE v
                                    inner join PHIEUDATCHO pdc ON pdc.MaPhieuDat=v.MaPhieuDat
                                    where pdc.Huy='0'";
                
            return _connect.Read(connectstring);
        }
        public void xoa(string mapd, string mav)
        {
            string connectstring = @" UPDATE PHIEUDATCHO SET Huy=N'" + "1" + "'where  MaPhieuDat =N'" + mapd + "'";
            _connect.Write(connectstring);
             connectstring = @" UPDATE VE SET DaLayVe=N'" + "2" + "'where  MaVe =N'" + mav + "'";
             _connect.Write(connectstring);
        }
        public string lay_da_lay_ve(string mav)
        {
            string connectstring = @"Select  v.DaLayVe
                                    from  VE v
                                    where v.MaVe=N'" + mav + "'";

            return _connect.Read(connectstring).Rows[0].ItemArray[0].ToString();
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
        public DataTable lay_danh_sach_macb_co_ve_chua_thanh_toan(string ngay)
        {
            // lay danh sach macb co ve chua thanh toan 
            string connectstring = @"Select distinct v.MaChuyenBay
                                    from VE v
                                    inner join PHIEUDATCHO pdc ON v.MaPhieuDat=pdc.MaPhieuDat
                                    inner join CHUYENBAY cb ON cb.MaChuyenBay = v.MaChuyenBay
									where v.DaLayVe='0' and v.MaPhieuDat IS NOT NULL";
            string connectStr = @"select v.MaPhieuDat,v.MaVe,v.MaChuyenBay,v.HangVe
                                from CHUYENBAY cb
                                inner join VE v ON cb.MaChuyenBay = v.MaChuyenBay
                                where cb.NgayKhoiHanh <=N'" + ngay + "'and cb.MaChuyenBay IN(" + connectstring + ")and v.DaLayVe='0' and v.MaPhieuDat IS NOT NULL";
            return _connect.Read(connectStr);
        }

        
    }
}
