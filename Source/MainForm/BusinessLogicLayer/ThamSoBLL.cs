using MainForm.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.BusinessLogicLayer
{
    class ThamSoBLL
    {
        private ThamSoDAL _connect = new ThamSoDAL();
        public DataTable LayThamSo()
        {
            return _connect.LayThamSo();
        }
        public void ThemThamSo(int sbtg, int tgdtt, int tgdtd, int tgbtt, int hcdv, int stt)
        {
            _connect.ThemThamSo(sbtg, tgdtt, tgdtd, tgbtt, hcdv, stt);
        }
        public void SuaThamSo(int sbtg, int tgdtt, int tgdtd, int tgbtt, int hcdv, int stt)
        {
            _connect.SuaThamSo(sbtg, tgdtt, tgdtd, tgbtt, hcdv, stt);
        }
    }
}
