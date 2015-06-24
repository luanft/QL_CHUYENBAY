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
using CrystalDecisions.CrystalReports.Engine;
using MainForm.BusinessLogicLayer;

namespace MainForm
{
    public partial class BaoCaoThang : Form
    {
        //QLCBDataContext db = new QLCBDataContext();
        QuanLyBaoCaoBLL bll = new QuanLyBaoCaoBLL();
        ReportDocument cry = new ReportDocument();

        public BaoCaoThang()
        {
            InitializeComponent();
        }

        private string _name = "BAOCAOTHANG";

        private string _parentForm;
        public string BeCalledByForm
        {
            get { return _parentForm; }
            set { _parentForm = value; }
        }

        public string NAME
        {
            get { return _name; }
        }

        private void BaoCaoThang_Load(object sender, EventArgs e)
        {
            comboBox_Thang.Enabled = false;
            DataTable dt_check = bll.LayNamThang();
            if (dt_check.Rows.Count != 0)
            {
                combox_Nam.DataSource = dt_check;
                combox_Nam.DisplayMember = "Year";
                combox_Nam.ValueMember = "Year";
            }
            else
            {
                combox_Nam.Enabled = false;
                buttonBaoCaoThang.Enabled = false;  
            }
        }

        //private void button5_Click(object sender, EventArgs e)
        //{

        //    switch (MessageBox.Show(this, "Bạn có muốn thoát khỏi chương trình không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        //    {

        //        case DialogResult.Yes:
        //            Application.Exit();
        //            break;
        //        case DialogResult.No:
        //            break;
        //    }

        //}

        private void button4_Click(object sender, EventArgs e)
        {
            //FormManager.CurrentBaoCaoThang.Close();
            Close();
        }

        private void BaoCaoThang_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region cmt
            //if (e.CloseReason == CloseReason.WindowsShutDown) return;

            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    // Assume that X has been clicked and act accordingly.
            //    // Confirm user wants to close
            //    switch (MessageBox.Show(this, "B?n có mu?n d?ng vi?c l?p báo cáo tháng không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //    {

            //        case DialogResult.Yes:
            //            switch (BeCalledByForm)
            //            {
            //                case "MAINFORM":
            //                    e.Cancel = false;
            //                    FormManager.CurrentBaoCaoThang = null;
            //                    FormManager.CurrentMainForm.Show();
            //                    break;
            //            }
            //            break;
            //        case DialogResult.No:
            //            e.Cancel = true;
            //            break;
            //    }
            //}
            #endregion
        }

        private void buttonBaoCaoThang_Click(object sender, EventArgs e)
        {
            //dataGridViewKQ.Rows.Clear();

            int thang = Convert.ToInt16(comboBox_Thang.SelectedValue.ToString());
            int nam = Convert.ToInt16(combox_Nam.SelectedValue.ToString());


            cry.Load(@"E:\TÀI LIỆU ĐẠI HỌC\HK6\Bảo trì phần mềm\QuanLyChuyenBay\trunk\source\MainForm\Giao Dien\Bao Cao\BaoCaoThang.rpt");
            DataSet ds = new DataSet();
            DataTable dt_baocao = bll.LapBaoCaoThang(thang, nam);
            if (dt_baocao == null)
            {
                MessageBox.Show("Hiện tại chưa có dữ liệu của *THÁNG* hoặc *NĂM* đã chọn. Vui lòng kiểm tra lại !!!");
            }
            else
            {
                ds.Tables.Add(dt_baocao);
                cry.SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = cry;
            }    
                #region cmt
// Vì vi?t theo 3 l?p nên LinQ không phù h?p c?u trúc chung   
            //    int SoNgay = SoNgayTrongThang(thang, nam);
            //    Table<CHUYENBAY> temp = db.GetTable<CHUYENBAY>();
            //    Table<HANGVE> hangves = db.GetTable<HANGVE>();
            //    Table<CTGHE> ctgs = db.GetTable<CTGHE>();
            //    var chuyenbays = from k in temp
            //                     where (k.NgayKhoiHanh.Value.Year == nam
            //                     && k.NgayKhoiHanh.Value.Month == thang)
            //                     select k;
            //    for (int i = 1; i <= SoNgay; i++)
            //    {
            //        int sochuyenbay = 0;
            //        double doanhthu = 0;
            //        foreach (var cb in chuyenbays)
            //        {
            //            if (cb.NgayKhoiHanh.Value.Day == i)
            //            {
            //                sochuyenbay++;
            //                foreach (var ctg in ctgs)
            //                {
            //                    if (cb.MaChuyenBay == ctg.MaChuyenBay)
            //                    {
            //                        HANGVE hv = hangves.Single(p => p.MaHangVe == ctg.MaHangVe);
            //                        doanhthu += Convert.ToDouble(ctg.SoGheDat * (cb.DonGia + cb.DonGia * hv.TiLeDonGia));
            //                    }
            //                }
            //            }
            //        }
            //        if (sochuyenbay > 0)
            //        {
            //            dataGridViewKQ.Rows.Add
            //                    (
            //                        i.ToString(),
            //                        sochuyenbay.ToString(),
            //                        doanhthu.ToString(),
            //                        ""
            //                    );
            //        }
            //    }

            //    double tongdoanhthu = 0;
            //    for (int i = 0; i < dataGridViewKQ.Rows.Count - 1; i++)
            //    {
            //        tongdoanhthu += Convert.ToDouble(dataGridViewKQ.Rows[i].Cells[2].Value.ToString());
            //    }
            //    for (int i = 0; i < dataGridViewKQ.Rows.Count - 1; i++)
            //    {
            //        dataGridViewKQ.Rows[i].Cells[3].Value = Math.Round((Convert.ToInt16(dataGridViewKQ.Rows[i].Cells[2].Value.ToString()) / tongdoanhthu), 3).ToString();
            //    }
#endregion
        }
        private bool CheckRules()
        {
            if (combox_Nam.SelectedValue.ToString() == "" || comboBox_Thang.SelectedValue.ToString() == "")
            {
                MessageBox.Show("không thể bỏ trống năm hoặc tháng!");
                return false;
            }
            #region cmt
     //QLCBRules _rule = new QLCBRules();
//             if (!_rule.IsNNumber(textBoxNam.Text) || !_rule.IsNNumber(textBoxThang.Text))
//             {
//                 MessageBox.Show("Tháng nam ph?i là m?t s? nguyên!");
//                 return false;
//             }
     #endregion

            int thang = Convert.ToInt16(comboBox_Thang.SelectedValue.ToString());
            int nam = Convert.ToInt16(combox_Nam.SelectedValue.ToString());
            if (thang < 1 || thang > 12)
            {
                MessageBox.Show("Tháng không hợp lệ!");
                return false;
            }
            if (nam < 1900 || nam > 2050)
            {
                MessageBox.Show("năm không thể nhỏ hơn 1900 hay lớn hơn 2050!");
                return false;
            }
            return true;

        }
        #region cmt
 // dã chuy?n qua BLL
        //private bool LaNamNhuan(int nam)
        //{
        //    if (nam % 4 == 0 && nam % 100 != 0)
        //        return true;
        //    return false;
        //}
        //int SoNgayTrongThang(int thang, int nam)
        //{
        //    if (thang == 1 || thang == 3 || thang == 5 || thang == 7
        //        || thang == 8 || thang == 10 || thang == 12) return 31;
        //    if (thang == 4 || thang == 6 || thang == 9 || thang == 11) return 30;
        //    if (LaNamNhuan(nam))
        //        return 29;
        //    return 28;
        //}
 #endregion


        private void textBoxNamBaoCao_Validating(object sender, CancelEventArgs e)
        {

        }

        private void combox_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Thang.Enabled = true;
            buttonBaoCaoThang.Enabled = true;
            comboBox_Thang.DataSource = bll.LayThang(combox_Nam.SelectedValue.ToString());
            comboBox_Thang.DisplayMember = "Thang";
            comboBox_Thang.SelectedValue = "Thang";
        }

      

    }
}
