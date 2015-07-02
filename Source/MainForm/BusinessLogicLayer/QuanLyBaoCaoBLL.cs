using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MainForm.DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
namespace MainForm.BusinessLogicLayer
{
    
    class QuanLyBaoCaoBLL
    {

        QuanLyBaoCaoDAL dal = new QuanLyBaoCaoDAL();
        public DataTable LayNamThang()
        {
            return dal.LayNamThang();
        }
        public DataTable LayThang(string nam)
        {
            return dal.LayThang(nam);
        }
        public DataTable LayNam()
        {
            return dal.LayNam();
        }
        
        private bool LaNamNhuan(int nam)
        {
            if (nam % 4 == 0 && nam % 100 != 0)
                return true;
            return false;
        }

        private int SoNgayTrongThang(int thang, int nam)
        {
            if (thang == 1 || thang == 3 || thang == 5 || thang == 7
                || thang == 8 || thang == 10 || thang == 12) return 31;
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11) return 30;
            if (LaNamNhuan(nam))
                return 29;
            return 28;
        }

        public DataTable LapBaoCaoNam(int nam)
        {
            DataTable dt_save = dal.LayDoanhThuThang(nam);
            if (dt_save.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                double tongDoanhThuNam = 0;
                int tongChuyenBay = 0;
                foreach (DataRow dr in dt_save.Rows)
                {
                    tongDoanhThuNam +=   Convert.ToDouble(dr["DoanhThu"].ToString());
                    tongChuyenBay += Convert.ToInt32(dr["SoChuyenBay"].ToString());
                }
                DataColumn newColumn = new DataColumn("TongDoanhThu", typeof(string));
                newColumn.DefaultValue = tongDoanhThuNam;
                dt_save.Columns.Add(newColumn);

                DataColumn newColumn1 = new DataColumn("TongChuyenBay", typeof(string));
                newColumn1.DefaultValue = tongChuyenBay.ToString();
                dt_save.Columns.Add(newColumn1);
                try
                {
                    dal.LuuDoanhThuNam(nam.ToString(), tongDoanhThuNam.ToString());
                }
                catch (SqlException e)
                {
                    dal.UpdateDTN(nam.ToString(), tongDoanhThuNam.ToString());
                }
                return dt_save;
            }
            
        }

        public DataTable LapBaoCaoThang(int thang, int nam)
        {
            DataTable dt_save = new DataTable();
            dt_save.Columns.Add("NgayTrongThang", typeof(string));
            dt_save.Columns.Add("SoChuyenBay", typeof(string));
            dt_save.Columns.Add("DoanhThu", typeof(string));
            dt_save.Columns.Add("Thang", typeof(string));
            dt_save.Columns.Add("Nam", typeof(string));
            dt_save.Columns.Add("TongChuyenBay", typeof(string));
            dt_save.Columns.Add("TongDoanhThu", typeof(string));

            int soNgay = SoNgayTrongThang(thang, nam);
            DataTable dt_chuyenBay = dal.LayChuyenBay(thang, nam);
            if (dt_chuyenBay.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                DataTable dt_hangVe = dal.LayHangVe();
                int tongSoChuyenBay = 0;
                double tongDoanhThu = 0;
                for (int i = 1; i <= soNgay; i++)
                {
                    int soChuyenBay = 0;
                    double doanhThu = 0;
                    foreach (DataRow dr in dt_chuyenBay.Rows)
                    {

                        var date = DateTime.Parse(dr["NgayKhoiHanh"].ToString());
                        int day = date.Day;
                        if (day == i)
                        {

                            soChuyenBay++;
                            tongSoChuyenBay = tongSoChuyenBay + soChuyenBay;
                            DataTable dt_loaiGhe = dal.LayLoaiGhe(dr["MaChuyenBay"].ToString());
                            int soGheDat = Int32.Parse(dt_loaiGhe.Rows[0]["SoGheDat"].ToString());
                            int donGia = Int32.Parse(dr["DonGia"].ToString());
                            foreach (DataRow hv in dt_hangVe.Rows)
                            {
                                if (dt_loaiGhe.Rows[0]["MaChuyenBay"].ToString() == hv["MaHangVe"].ToString())
                                {
                                    float tiLeDonGia = float.Parse(hv["TiLeDonGia"].ToString());
                                    doanhThu += Convert.ToDouble(soGheDat * (donGia + donGia * tiLeDonGia));
                                    tongDoanhThu += doanhThu;
                                }
                            }
                        }
                    }
                    if (soChuyenBay > 0)
                    {
                        dt_save.Rows.Add(i.ToString(),
                                        soChuyenBay.ToString(),
                                        doanhThu.ToString(),
                                        thang.ToString(),
                                        nam.ToString(),
                                        tongSoChuyenBay.ToString(),
                                        tongDoanhThu.ToString());
                    }
                }
                try
                {
                    dal.LuuDoanhThuThang(thang.ToString(), nam.ToString(), tongSoChuyenBay.ToString(), tongDoanhThu.ToString());
                }
                catch
                {
                    dal.UpdateDTT(thang.ToString(), nam.ToString(), tongSoChuyenBay.ToString(), tongDoanhThu.ToString());
                }
                return dt_save;
            }
            
        }
    }
}
