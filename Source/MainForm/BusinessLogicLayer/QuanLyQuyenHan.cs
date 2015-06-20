using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainForm.BusinessLogicLayer
{
    class QuanLyQuyenHan
    {
        
        Dictionary<string, bool> functionList = new Dictionary<string, bool>();
        private void Init(DataTable dataSource)
        {
            foreach (DataRow i in dataSource.Rows)
            {
                functionList.Add(i["MaChucNang"].ToString().Trim(), false);
            }            
        }
        public QuanLyQuyenHan(DataTable dataSource)
        {
            Init(dataSource);
        }
        public QuanLyQuyenHan()
        {

        }
        public void Add(string fname, bool fvalue)
        {
            this.functionList.Add(fname, fvalue);
        }
        void Remove(string fname)
        {
            this.functionList.Remove(fname);
        }

        public void SetValue(string fname,bool fvalue)
        {
            this.functionList[fname] = fvalue;
        }

        public bool GetUserRight(string fname)
        {
            return this.functionList[fname];
        }

    }
}
