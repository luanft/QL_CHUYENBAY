using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MainForm.DataAccessLayer;

namespace MainForm.BusinessLogicLayer
{
    class TraVeBLL
    {
        TraVeDAL _connect = new TraVeDAL();
        public string[] lay_danh_sach_ma_ve()
        {
            DataTable d = _connect.lay_danh_sach_ma_ve();
            string[] data = new string[d.Rows.Count];
            for (int i = 0; i < d.Rows.Count; i++)
            {
                data[i] = d.Rows[i].ItemArray[0].ToString();
            }
            return data;
        }
        public DataTable lay_danh_sach_ve()
    {
        return _connect.lay_danh_sach_ve();
    }
        public string lay_thong_tin_san_bay_di(string macb)
        {
            return _connect.lay_thong_tin_SB_di(macb);
        }
        public string lay_thong_tin_san_bay_den(string macb)
        {
            return _connect.lay_thong_tin_SB_den(macb);
        }
        public string lay_thoi_gian_bay(string macb)
        {
            return _connect.lay_thoi_gian_bay(macb);
        }
        public string lay_ngay_khoi_hanh(string macb)
        {
            DateTime d = DateTime.Parse(_connect.lay_ngay_khoi_hanh(macb));
            string ngay, thang, nam;
            if (d.Day < 10)
                ngay = "0" + d.Day;
            else
                ngay = d.Day.ToString();
            if (d.Month < 10)
                thang = "0" + d.Month;
            else
                thang = d.Month.ToString();


            string ngay_ = ngay + "-" + thang + "-" + d.Year;
            return ngay_;
        }
        public string lay_gio_khoi_hanh(string macb)
        {
            DateTime d = DateTime.Parse(_connect.lay_gio_khoi_hanh(macb));
            string gio, phut, giay;
            if (d.Hour < 10)
                gio = "0" + d.Hour;
            else
                gio = d.Hour.ToString();
            if (d.Minute < 10)
                phut = "0" + d.Minute;
            else
                phut = d.Minute.ToString();
            if (d.Second < 10)
                giay = "0" + d.Second;
            else
                giay = d.Second.ToString();


            string gio_ = gio + ":" + phut + ":" + giay;
            return gio_;
        }
        public DataTable lay_danh_sach_SBTG(string macb)
        {
            return _connect.lay_danh_sach_SBTG(macb);
        }
        public string lay_ten_hang_ve(string mahv)
        {
            return _connect.lay_ten_hang_ve(mahv);
        }
        public string lay_gia_hang_ve(string macb, string mahv)
        {
            return _connect.lay_gia_hang_ve(macb, mahv);
        }
        public string lay_macb(string mav)
        {
            return _connect.lay_macb(mav);
        }
        public string lay_tenhk(string mav)
        {
        return _connect.lay_tenhk( mav);
        }
        public string lay_cmnd(string mav)
        {
            return _connect.lay_cmnd(mav);
        }
        public string lay_sdt(string mav)
        {
            return _connect.lay_sdt(mav);
        }
        public string lay_mahangve(string mav)
        {
            return _connect.lay_mahangve(mav);
        }
        public string lay_giatien(string mav)
        {
            return _connect.lay_giatien(mav);
        }
        public void xoa(string mav,string mcb, string mhv)
        {
            // xoa ve
            _connect.xoa(mav);
            // xoa phieu dat neu co
            _connect.xoa_pd(_connect.lay_mpd(mav));
            // tang so ghe trong len 1;
            int sl = _connect.lay_so_ghe_trong(mcb, mhv) +1;
            _connect.cap_nhat_so_ghe_trong(mcb,mhv, sl);
            // giam so ghe datt xuong 1
            sl = _connect.lay_so_ghe_da_dat(mcb, mhv) - 1;
            _connect.cap_nhat_so_ghe_da_dat(mcb, mhv, sl);
        }

    }
}
