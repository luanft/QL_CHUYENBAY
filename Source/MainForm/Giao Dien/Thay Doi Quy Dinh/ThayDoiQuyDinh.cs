using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;
using MainForm.DataAccessLayer;

namespace MainForm
{
    public partial class QuyDinh : Form
    {                
        public QuyDinh()
        {
            InitializeComponent();
            updateData();
        }
        private void InitCC()
        {            
        }
        private string _parentForm;
        public string BeCalledByForm
        {
            get { return _parentForm; }
            set { _parentForm = value; }
        }
        //private ThamSoDAL _connect = new ThamSoDAL();
        private void _btcapnhat_Click(object sender, EventArgs e)
        {            
//             try
//             {
//                 if (textBoxHangChotDatVe.Text == "")
//                 {
//                     _connect.ThemThamSo(Int32.Parse(textBoxSoSanBayTGToiDaMoi.Text),
//                         Int32.Parse(textBoxThoiGianDungToiThieuMoi.Text),
//                         Int32.Parse(textBoxThoiGianDungToiDaMoi.Text),
//                         Int32.Parse(textBoxThoiGianBayToiThieuMoi.Text),
//                         Int32.Parse(textBoxHangChotDatVeMoi.Text),
//                         1);
//                 }
//                 else { 
//                 _connect.SuaThamSo(Int32.Parse(textBoxSoSanBayTGToiDaMoi.Text),
//                     Int32.Parse(textBoxThoiGianDungToiThieuMoi.Text), 
//                     Int32.Parse(textBoxThoiGianDungToiDaMoi.Text),
//                     Int32.Parse(textBoxThoiGianBayToiThieuMoi.Text),
//                     Int32.Parse(textBoxHangChotDatVeMoi.Text),
//                     1);
//                 }
//             }
//             catch (Exception ex)
//             {
//                 MessageBox.Show("Vui Lòng kiểm tra dữ liệu nhập của bạn");
//             }
//             updateData();
        }
        public void updateData()
        {
            //             DataTable r = _connect.LayThamSo();
            //             if (r.Rows.Count == 0)
            //                 return;
            // 
            //             textBoxSoSanBayTGToiDa.Text = r.Rows[0]["SoSanBayTrungGianToiDa"].ToString();
            //             textBoxThoiGianBayToiThieu.Text = r.Rows[0]["ThoiGianBayToiThieu"].ToString();
            //             textBoxThoiGianDungToiDa.Text = r.Rows[0]["ThoiGianDungToiDa"].ToString();
            //             textBoxThoiGianDungToiThieu.Text = r.Rows[0]["ThoiGianDungToiThieu"].ToString();
            //             textBoxHangChotDatVe.Text = r.Rows[0]["HangChotDatVe"].ToString();
            //         }
            //         private void _btthoat_Click(object sender, EventArgs e)
            //         {
            //             this.Close();
            //         }
            //   
        }                             
    }
}
