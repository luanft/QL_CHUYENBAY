using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.BusinessLogicLayer
{
    class GiaoDienHoTroBLL
    {
        private DataAccessLayer.GiaoDienHoTroDAL _connect = new DataAccessLayer.GiaoDienHoTroDAL();
        public DataTable LayTuyenBay()
        {
            return _connect.LayTuyenBay();
        }
        public DataTable LayMaSanBay()
        {
            return _connect.LayMaSanBay();
        }
        public void ThemTuyenBay(String matuyenbay, String masbdi, String masbden) {
            _connect.ThemTuyenBay(matuyenbay,masbdi,masbden);
        }
        public void SuaTuyenBay(String matuyenbay, String _Nmasbdi, String _Nmasbden) {
            _connect.SuaTuyenBay(matuyenbay,_Nmasbdi,_Nmasbden);
        }
        public void XoaTuyenBay(String matuyenbay) {
            _connect.XoaTuyenBay(matuyenbay);
        }
        public DataTable LaySanBay()
        {
            return _connect.LaySanBay();
        }
        public void ThemSanBay(String masb, String tensb, String diachi){
            _connect.ThemSanBay(masb,tensb,diachi);
        }
        public void SuaSanBay(String masb, String tensb, String diachi){
            _connect.SuaSanBay(masb,tensb,diachi);
        }
        public void XoaSanBay(String masb){
            _connect.XoaSanBay(masb);
        }
        public DataTable LayHangVe()
        {
            return _connect.LayHangVe();
        }

        public void ThemHangVe(String mahv, String tenhv, float tiledongia){
            _connect.ThemHangVe(mahv,tenhv,tiledongia);
        }
        public void SuaHangVe(String mahv, String _Ntenhv, float _Ntiledongia){
            _connect.SuaHangVe(mahv,_Ntenhv,_Ntiledongia);
        }
        public void XoaHangVe(String mahv){
            _connect.XoaHangVe(mahv);
        }                    
    }
}
  