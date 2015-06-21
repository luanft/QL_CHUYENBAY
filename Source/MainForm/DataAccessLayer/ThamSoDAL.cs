using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.DataAccessLayer
{
    class ThamSoDAL
    {
        private DataConnection _connect = DataConnection.getInstance();
        public DataTable LayThamSo()
        {
            String _sql = "select * from THAMSO";
            return _connect.Read(_sql);
        }
        public void ThemThamSo(int sbtg, int tgdtt, int tgdtd, int tgbtt,int hcdv, int stt)
        {
            String _sql = "insert into THAMSO values(" + sbtg + "," + tgdtt + "," + tgdtd + ","  + tgbtt + ","+ hcdv + "," + stt + ")";
            _connect.Write(_sql);
        }
        public void SuaThamSo(int sbtg, int tgdtt, int tgdtd, int tgbtt, int hcdv, int stt)
        {
            String _sql = "update THAMSO set SoSanBayTrungGianToiDa = "+sbtg+", ThoiGianDungToiThieu = "+tgdtt+",ThoiGianDungToiDa = "+tgdtd+",ThoiGianBayToiThieu = " + tgbtt+",HangChotDatVe = "+hcdv+",STT = "+stt;
            _connect.Write(_sql);
        }
    }
}
