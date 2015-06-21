using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.DataAccessLayer
{
    class GiaoDienHoTroDAL
    {
        DataConnection _connect = DataConnection.getInstance();
        public DataTable LayTuyenBay()
        {
            String sql = "select MaTuyenBay[Mã Tuyến Bay], MaSanBayDi[Mã Sân Bay Đi],MaSanBayDen[Mã Sân Bay Đến] from TUYENBAY";
            return _connect.Read(sql);

        }
        public DataTable LayHangVe()
        {
            String _sql = "select MaHangVe[Mã Hạng Vé], TenHangVe[Tên Hạng Vé], TiLeDonGia[Tỉ Lệ Đơn Giá] from HANGVE";
            return _connect.Read(_sql);
        }
        public DataTable LaySanBay()
        {
            String _sql = "select MaSanBay[Mã Sân Bay], TenSanBay[Tên Sân Bay], DiaChi[Địa Chỉ] from SANBAY";
            return _connect.Read(_sql);
        }
        public DataTable LayMaSanBay(String xxx)
        {
            String _sql = "select MaSanBay from SANBAY where SANBAY.MaSanBay !=N'" + xxx+"'";
            return _connect.Read(_sql);
        }
        public bool  kiemtratuyenbay(String di, String den)
        {
            String sql = "select * from TUYENBAY where MaSanBayDi = N'"+di+"' and MaSanBayDen = N'"+den+"'";
            DataTable _t = _connect.Read(sql);
            if (_t.Rows.Count != 0)
                return false;
            return true;
        }
        public void ThemTuyenBay(String matuyenbay, String masbdi, String masbden)
        {
            String sql = "insert into TUYENBAY values(N'"+matuyenbay+"',N'"+masbdi+"',N'"+masbden+"')";
            _connect.Write(sql);   
        }
        public void SuaTuyenBay(String matuyenbay, String _Nmasbdi, String _Nmasbden)
        {
            String sql = "update TUYENBAY set TUYENBAY.MaSanBayDi = N'" + _Nmasbdi + "', TUYENBAY.MaSanBayDen = N'" + _Nmasbden + "' where TUYENBAY.MaTuyenBay = N'" + matuyenbay + "'";
            _connect.Write(sql);
        }
        public void XoaTuyenBay(String matuyenbay)
        {
            String _sql = "delete from TUYENBAY where TUYENBAY.MaTuyenBay = N'" + matuyenbay + "'";
            _connect.Write(_sql);
        }
        public void ThemSanBay(String masb, String tensb, String diachi){
            String sql = "insert into SANBAY values(N'"+masb+"',N'"+tensb+"',N'"+diachi+"')";
            _connect.Write(sql);
        }
        public void SuaSanBay(String masb, String tensb, String diachi){
            String _sql = "update SANBAY set SANBAY.TenSanBay = N'"+tensb+"', SANBAY.DiaChi = N'"+diachi+"' where SANBAY.MaSanBay = N'"+masb+"'";
            _connect.Write(_sql);
        }
        public void XoaSanBay(String masb)
        {
            String _sql = "delete from SANBAY where SANBAY.MaSanBay = N'" + masb + "'";
            _connect.Write(_sql);
        }
        public void ThemHangVe(String mahv, String tenhv, float tiledongia){
            String sql = "insert into HANGVE values(N'" + mahv + "',N'" + tenhv + "'," + tiledongia + ")";
            _connect.Write(sql);
        }
        public void SuaHangVe(String mahv, String _Ntenhv, float _Ntiledongia)
        {
            String _sql = "update HANGVE set HANGVE.TenHangVe = N'" + _Ntenhv + "', HANGVE.TiLeDonGia = N'" + _Ntiledongia + "' where HANGVE.MaHangVe = N'" + mahv + "'";
            _connect.Write(_sql);
        }
        public void XoaHangVe(String mahv)
        {
            String _sql = "delete from HANGVE where HANGVE.MaHangVe = N'" + mahv + "'";
            _connect.Write(_sql);
        }
    }
}
