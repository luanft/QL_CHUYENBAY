using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.BusinessLogicLayer
{
    class ThemChuyenBayBLL
    {
        DataAccessLayer.ThemChuyenBayDAL dal = new DataAccessLayer.ThemChuyenBayDAL();

        public DataTable LayDanhSachMaTuyenBay()
        {
            return dal.LayDanhSachMaTuyenBay();
        }

        public DataTable LayDanhSachHangVe()
        {
            return dal.LayCacHangVe();
        }

        public string LayMaChuyenBayTiepTheo()
        {
            DataTable dt=dal.LayMaChuyenBayCuoiBang();
            if (dt.Rows.Count < 1)
                return "CB001";
            return LayMaChuyenBayTiepTheo(dt.Rows[0][0].ToString());
        }
        public string LayMaChuyenBayTiepTheo(string MaChuyenBayHienTai)
        {
            int next = int.Parse(MaChuyenBayHienTai.Substring(2, 3)) + 1;
            if (next < 10) return "CB00" + next.ToString();
            else if (next < 100) return "CB0" + next.ToString();
            else return "CB" + next.ToString();
        }
        public DataTable LayDanhSachMaHangVe()
        {
            return dal.LayDanhSachHangVe();
        }
        public DataTable LayDanhSachSanBayTrungGian(string MaSanBayDen, string MaSanBayDi)
        {
            return dal.LayDanhSachTenSanBayTrungGian(MaSanBayDen, MaSanBayDi);
        }
        public string LayTenSanBayDi(string MaChuyenBay)
        {
            if (dal.LayTenSanBayDi(MaChuyenBay).Rows.Count < 1)
                return null;
            return dal.LayTenSanBayDi(MaChuyenBay).Rows[0][0].ToString();
        }
        public string LayTenSanBayDen(string MaChuyenBay)
        {
            if (dal.LayTenSanBayDen(MaChuyenBay).Rows.Count < 1)
                return null;
            return dal.LayTenSanBayDen(MaChuyenBay).Rows[0][0].ToString();
        }
        public void ThemChuyenBay(string MaChuyenBay, string MaTuyenBay, int 
            ThoiGianBay, double DonGia, string NgayKhoiHanh, string GioKhoiHanh)
        {
            dal.ThemChuyenBay(MaChuyenBay, MaTuyenBay, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh);
        }
        public void ThemLoaiGhe(string MaChuyenBay, string MaHangVe, int SoGhe)
        {
            dal.ThemLoaiGhe(MaChuyenBay, MaHangVe, SoGhe, 0, SoGhe);
        }
        public void ThemSanBayTrungGian(string MaChuyenBay, string MaSanBay, int ThoiGianDung, string GhiChu)
        {
            dal.ThemSanBayTrungGian(MaChuyenBay, MaSanBay, ThoiGianDung, GhiChu);
        }
        public int LayThamSo(string TenThamSo)
        {
            if (dal.LayThamSo(TenThamSo).Rows.Count < 1)
                return 0;
            return int.Parse(dal.LayThamSo(TenThamSo).Rows[0][0].ToString()); 
        }


    }
}
