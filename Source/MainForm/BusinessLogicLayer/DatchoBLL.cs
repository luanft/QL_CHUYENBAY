using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MainForm.DataAccessLayer ;
using System.Windows.Forms;

namespace MainForm.BusinessLogicLayer
{
    class DatchoBLL
    {
        DatchoDAL _connect = new DatchoDAL();
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
            string so;
            int t =int.Parse( _connect.tong_so_luong_ve())+1;
            if (t < 10)
                so = "0" + t;
            else
                so = t.ToString();
            string ma = "MV" + so;
            return ma;
        }
        public string tao_ma_phieu_dat()
        {
            string so;
            int t = int.Parse(_connect.tong_so_luong_phieu_dat()) + 1;
            if (t < 10)
                so = "0" + t;
            else
                so = t.ToString();
            string ma = "MPD" + so;
            return ma;
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
        public string lay_ten_hang_ve(string mahv)
        {
            return _connect.lay_ten_hang_ve(mahv);
        }
        public string lay_gia_hang_ve(string macb, string mahv)
        {
            return _connect.lay_gia_hang_ve(macb, mahv);
        }
        public void luu(string mapdh,string mave, string macb,string mahv,string giatien, string tennd, string cmndnd, string sdtnd, string tenhk, string cmndhk, string sdthk)
        {
            _connect.luu_phieu_dat(mapdh, DateTime.Now.ToString(), tennd, cmndnd, sdtnd, "0");// huy =0 la ko huy, 1 = da huy
            _connect.luu_ve_(mave, macb, tenhk, cmndhk, sdthk, mahv, "0", giatien,mapdh);// da lay =0 => load len combobox ben lay ve, da lay=1 => load len ve khi mua , da lay =2 => da xoa
            // giam so luong ghe trong
            int sl = _connect.lay_so_ghe_trong(macb, mahv)-1;
            _connect.cap_nhat_so_ghe_trong(macb, mahv, sl);
            // tang so luong ghe da dat 
            sl = _connect.lay_so_ghe_da_dat(macb, mahv)+1;
            _connect.cap_nhat_so_ghe_da_dat(macb, mahv, sl);
        }
         public int lay_quy_dinh_han_chot_dat_ve()
         {
             return int.Parse(_connect.lay_quy_dinh_han_chot_dat_ve());
         }
        //public int lay_quy_dinh_han_chot_huy_ve()
        // {
        //     return int.Parse(_connect.lay_quy_dinh_han_chot_huy_ve());
        // }
         public DataTable lay_danh_sach_khi_load_form()
         {
             return _connect.lay_danh_sach_khi_load_form();
         }
         public void cap_nhat_(string mave, string mcb, string tenhk, string cmndhk, string sdthk, string mahv, string giatien, string mapd,string tennd, string cmndnd, string sdtnd)
         {
             _connect.cap_nhat_ve_(mave, mcb, tenhk, cmndhk, sdthk, mahv, "0", giatien, mapd);
             _connect.cap_nhat_phieu_dat( mapd,DateTime.Now.ToString(),  tennd,  cmndnd,  sdtnd,  "0");
         }
         public void xoa(string mapd, string mav,string macb, string mahv)
         {
             if (int.Parse(_connect.lay_da_lay_ve(mav)) == 1)
             {
                 MessageBox.Show("Vé đã được lấy , không thể xóa phiếu đặt!");
             }
             else
             {
                 _connect.xoa(mapd, mav);
                 // tang so luong ghe trong
                 int sl = _connect.lay_so_ghe_trong(macb, mahv) + 1;
                 _connect.cap_nhat_so_ghe_trong(macb, mahv, sl);
                 // giam so luong ghe da dat
                 sl = _connect.lay_so_ghe_da_dat(macb, mahv) - 1;
                 _connect.cap_nhat_so_ghe_da_dat(macb, mahv, sl);
             }
         }
         public string lay_da_lay_ve(string mav)
         {
             return _connect.lay_da_lay_ve(mav);
         }
          public int lay_so_ghe_trong(string macb, string mahv)
          {
             return _connect.lay_so_ghe_trong( macb,  mahv);
          }
          public void cap_nhat_so_ghe_trong(string macb, string mahv, int soluong)
          {
              _connect.cap_nhat_so_ghe_trong(macb, mahv, soluong);
          }
          public int lay_so_ghe_da_dat(string macb, string mahv)
          {
              return _connect.lay_so_ghe_da_dat(macb, mahv);
          }
          public void cap_nhat_so_ghe_da_dat(string macb, string mahv, int soluong)
          {
              _connect.cap_nhat_so_ghe_da_dat(macb, mahv, soluong);
          }
         
          public int xoa_dat_cho_cach_hom_nay_1_ngay_chua_thanh_toan()
          {
              // kiem tra cb nao co ngay bay qua tre 
              DateTime now = DateTime.Now.AddDays(2);
              DataTable d = _connect.lay_danh_sach_macb_co_ve_chua_thanh_toan(now.ToString());
              //
              
              for (int i = 0; i < d.Rows.Count; i++)
              {
                  // xoa=> xoa phieu dat va xoa ve
                   _connect.xoa( d.Rows[i].ItemArray[0].ToString(),d.Rows[i].ItemArray[1].ToString());
                  // gtang so ghe trong
                   int sl = _connect.lay_so_ghe_trong(d.Rows[i].ItemArray[2].ToString(), d.Rows[i].ItemArray[3].ToString()) + 1;
                   _connect.cap_nhat_so_ghe_trong(d.Rows[i].ItemArray[2].ToString(), d.Rows[i].ItemArray[3].ToString(), sl);
                  // giam so ghe da dat 
                   sl = _connect.lay_so_ghe_da_dat(d.Rows[i].ItemArray[2].ToString(), d.Rows[i].ItemArray[3].ToString())-1;
                   _connect.cap_nhat_so_ghe_da_dat(d.Rows[i].ItemArray[2].ToString(), d.Rows[i].ItemArray[3].ToString(), sl);

              }
              return d.Rows.Count;
          }
    }
}
