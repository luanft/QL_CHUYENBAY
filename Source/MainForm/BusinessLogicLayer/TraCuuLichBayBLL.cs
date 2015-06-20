using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.BusinessLogicLayer
{
    class TraCuuLichBayBLL
    {
        DataAccessLayer.TraCuuLichBayDAL dal = new DataAccessLayer.TraCuuLichBayDAL();
        public DataTable LayDanhSachMaChuyenBay()
        {
            return dal.LayDanhSachMaChuyenBay();
        }
        public DataTable LayDanhSachTenSanBayDi(string MaTuyenBay)
        {
            return dal.LayDanhSachTenSanBayDi(MaTuyenBay);
        }
        public DataTable LayTenSanBayDen(string MaTuyenBay)
        {
            return dal.LayDanhSachTenSanBayDen(MaTuyenBay);
        }
        public DataTable LayDanhSachSanBay()
        {
            return dal.LayDanhSachSanBay();
        }
        public DataTable LayChuyenBay(string MaChuyenBay)
        {
            return dal.LayChuyenBay(MaChuyenBay);
        }
        public int LayTongSoGheDat(string MaChuyenBay)
        {
            return int.Parse(dal.LayTongSoGheDat(MaChuyenBay).Rows[0][0].ToString());
        }
        public int LayTongSoGheTrong(string MaChuyenBay)
        {
            return int.Parse(dal.LayTongSoGheTrong(MaChuyenBay).Rows[0][0].ToString());
        }
        public DataTable LayChuyenBay_theoSBdi(string TenSanBayDi)
        {
            return dal.LayChuyenBay_theoSBdi(TenSanBayDi);
        }
        public DataTable LayChuyenBay_theoSBden(string TenSanBayDen)
        {
            return dal.LayChuyenBay_theoSBden(TenSanBayDen);
        }
        public DataTable LayChuyenBay_theoNgay(string tuNgay, string denNgay)
        {
            return dal.LayChuyenBay_theoNgay(tuNgay, denNgay);
        }
        public DataTable LayChuyenBay_theoSBdenvadi(string TenSanBayDi, string TenSanBayDen)
        {
            return dal.LayChuyenBay_theoSBdenvadi(TenSanBayDi, TenSanBayDen);
        }
        public DataTable LayChuyenBay_theoSBden_NgayKhoiHanh(string TenSanBayDen, string tuNgay, string denNgay)
        {
            return dal.LayChuyenBay_theoSBden_NgayKhoiHanh(TenSanBayDen, tuNgay, denNgay);
        }
    }
}
