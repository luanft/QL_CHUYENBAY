using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MainForm.DataAccessLayer;

namespace MainForm.BusinessLogicLayer
{
    class LayveBLL
    {
        LayveDAL _connect = new LayveDAL();

        public string[] lay_danh_sach_ma_phieu_dat()
        {
            
            DataTable d  = _connect.lay_danh_sach_ma_phieu_dat();
            string []data = new string[d.Rows.Count];
            for (int i = 0; i < d.Rows.Count; i++)
            {
                data[i] = d.Rows[i].ItemArray[0].ToString();
            }
            return data;
        }
        public string[] lay_danh_sach_ma_CB()
        {
            DataTable d = _connect.lay_danh_sach_ma_CB();
            string[] data = new string[d.Rows.Count];
            for (int i = 0; i < d.Rows.Count; i++)
            {
                data[i] = d.Rows[i].ItemArray[0].ToString();
            }
            return data;
        }
        public string[] lay_danh_sach_ma_hang_ve(string machuyenbay)
        {
            DataTable d = _connect.lay_danh_sach_ma_hang_ve(machuyenbay);
            string[] data = new string[d.Rows.Count];
            for (int i = 0; i < d.Rows.Count; i++)
            {
                data[i] = d.Rows[i].ItemArray[0].ToString();
            }

            return data;
        }
        public string tao_ma_ve()
        {
            string s=null;
            int so_luong =int.Parse(_connect.tong_so_luong_ve())+1;
            if (so_luong < 10)
                s = "0" + so_luong;
            else
                s = so_luong.ToString();

            string r = "MV" + s ;
            return r;
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
            

            string ngay_ =ngay+ "-" + thang + "-" + d.Year;
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


            string gio_ = gio + ":" + phut + ":" +giay;
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
        public void luu_ve_moi_chua_dat(string mave, string mcb, string tenhk, string cmnd, string sdt, string mahv, string giatien)
        {
             string dalay= "1";
            _connect.luu_ve_moi_chua_dat(mave, mcb, tenhk, cmnd, sdt, mahv, dalay, giatien);
            // giam so luong ghe trong xuong 1
            int sl = _connect.lay_so_ghe_trong(mcb, mahv) - 1;
            _connect.cap_nhat_so_ghe_trong(mcb, mahv, sl);
            // tang so luong ghe da dat len 1
            sl = _connect.lay_so_ghe_da_dat(mcb, mahv) + 1;
            _connect.cap_nhat_so_ghe_da_dat(mcb, mahv, sl);
        }
        public int so_ghe_trong(string macb,string mahv)
        {
            return _connect.lay_so_ghe_trong(macb, mahv);
        }
        public DataTable lay_danh_sach_ve_khong_dat_truoc()
        {
           return _connect.lay_danh_sach_ve_khong_dat_truoc();
        }
        public DataTable lay_danh_sach_ve_da_dat_truoc()
        {
            return _connect.lay_danh_sach_ve_da_dat_truoc();
        }
        public string lay_thong_tin_ma_ve_da_dat(string mapd)
        {
            return _connect.lay_thong_tin_ma_ve_da_dat(mapd);
        }
        public string lay_thong_tin_ma_cb_da_dat(string mapd)
        {
            return _connect.lay_thong_tin_ma_cb_da_dat(mapd);
        }
        public string lay_thong_tin_te_kh_da_dat(string mapd)
        {

            return _connect.lay_thong_tin_te_kh_da_dat(mapd);
        }
        public string lay_thong_tin_cmnd_da_dat(string mapd)
        {


            return _connect.lay_thong_tin_cmnd_da_dat(mapd);
        }
        public string lay_thong_tin_sdt_da_dat(string mapd)
        {
          
            return _connect.lay_thong_tin_sdt_da_dat( mapd);
        }
        public string lay_thong_tin_hang_ve_da_dat(string mapd)
        {
             

            return _connect.lay_thong_tin_hang_ve_da_dat( mapd);
        }
        public void luu_ve_da_dat(string mave,string mcb, string mahv,string tenhk, string sdt,string cmnd)
        {
            _connect.luu_ve_da_dat(mave,tenhk,sdt,cmnd);
            
        }
        public void cap_nhat_ve_khong_dat_truoc(string mapd, string mave, string mcb, string tenhk, string cmnd, string sdt, string mahv, string giatien)
        {

            
            // Tang so luong ghe trong xuong 1
            int sl = _connect.lay_so_ghe_trong(_connect.lay_ma_cb(mave),_connect.lay_ma_hang_ve(mave)) + 1;
            _connect.cap_nhat_so_ghe_trong(_connect.lay_ma_cb(mave), _connect.lay_ma_hang_ve(mave), sl);
            // giam so luong ghe da dat len 1
            sl = _connect.lay_so_ghe_da_dat(_connect.lay_ma_cb(mave), _connect.lay_ma_hang_ve(mave)) - 1;
            _connect.cap_nhat_so_ghe_da_dat(_connect.lay_ma_cb(mave), _connect.lay_ma_hang_ve(mave), sl);

            _connect.cap_nhat_ve_khong_dat_truoc(mapd, mave, mcb, tenhk, cmnd, sdt, mahv, giatien);

            // giam so luong ghe trong xuong 1
            sl = _connect.lay_so_ghe_trong(mcb, mahv) - 1;
            _connect.cap_nhat_so_ghe_trong(mcb, mahv, sl);
            // tang so luong ghe da dat len 1
            sl = _connect.lay_so_ghe_da_dat(mcb, mahv) + 1;
            _connect.cap_nhat_so_ghe_da_dat(mcb, mahv, sl);

        }
        public void cap_nhat_ve_dat_truoc(string mave,string tenhk, string cmnd, string sdt)
        {
            _connect.cap_nhat_ve_dat_truoc( mave,tenhk, cmnd, sdt);
        }
    }
}
