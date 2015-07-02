using CrystalDecisions.CrystalReports.Engine;
using MainForm.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class BaoCaoNam : Form
    {
        //QLCBDataContext db = new QLCBDataContext();
        QuanLyBaoCaoBLL bll = new QuanLyBaoCaoBLL();
        ReportDocument cry = new ReportDocument();
        private string _parentForm;
        public string BeCalledByForm
        {
            get { return _parentForm; }
            set { _parentForm = value; }
        }
        
        public BaoCaoNam()
        {
            InitializeComponent();
        }

        private void BaoCaoNam_Load(object sender, EventArgs e)
        {
            DataTable aa= bll.LayNam();
            if (aa.Rows.Count > 0)
            {
                comboBox_Nam.DataSource = aa;
                comboBox_Nam.DisplayMember = "Nam";
                comboBox_Nam.ValueMember = "Nam";
            }
            else
            {
                comboBox_Nam.Enabled = false;
                buttonBaoCao.Enabled = false;
            }
            
        }

        private void buttonBaoCaoNam_Click(object sender, EventArgs e)
        {
            int nam = Convert.ToInt16(comboBox_Nam.SelectedValue.ToString());
            cry.Load(@"E:\TÀI LIỆU ĐẠI HỌC\HK6\Bảo trì phần mềm\QL_CHUYENBAY\trunk\Source\MainForm\Giao Dien\Bao Cao\BaoCaoNam.rpt");
            
            DataSet ds = new DataSet();
            DataTable dt_baocao = bll.LapBaoCaoNam(nam);
            if (dt_baocao == null)
            {
                MessageBox.Show("Hiện tại chưa có dữ liệu của *NĂM* đã nhập. Vui lòng kiểm tra lại !!!");
            }
            else
            {
                ds.Tables.Add(dt_baocao);
                cry.SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = cry;
            }
            #region cmt
         //dataGridViewKQ.Rows.Clear();
            //if (CheckRules())
            //{
            //    Table<CHUYENBAY> chuyenbays = db.GetTable<CHUYENBAY>();
            //    var dschuyenbay = from cb in chuyenbays
            //                      where (cb.NgayKhoiHanh.Value.Year == Convert.ToInt16(textBoxNam.Text))
            //                      select cb;
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        bool flag = false;
            //        int sochuyenbay = 0;
            //        double doanhthu = 0;
            //        foreach (var cb in dschuyenbay)
            //        {
            //            if (cb.NgayKhoiHanh.Value.Month == i)
            //            {
            //                flag = true;
            //                sochuyenbay += 1;
            //                Table<CTGHE> ctgs = db.GetTable<CTGHE>();
            //                foreach (var ctg in ctgs)
            //                {
            //                    if (ctg.MaChuyenBay == cb.MaChuyenBay)
            //                    {
            //                        Table<HANGVE> hangves = db.GetTable<HANGVE>();
            //                        HANGVE hv = hangves.Single(p => p.MaHangVe == ctg.MaHangVe);
            //                        doanhthu += Convert.ToDouble(ctg.SoGheDat * (cb.DonGia + cb.DonGia * hv.TiLeDonGia));
            //                    }
            //                }
            //                sochuyenbay++;
            //            }
            //        }
            //        if (flag)
            //        {
            //            dataGridViewKQ.Rows.Add
            //                (
            //                    i.ToString(),
            //                    sochuyenbay.ToString(),
            //                    doanhthu.ToString(),
            //                    ""
            //                );
            //        }
            //    }
            //    double tongdoanhthu = 0;
            //    for (int i = 0; i < dataGridViewKQ.Rows.Count - 1; i++ )
            //    {
            //        tongdoanhthu += Convert.ToDouble(dataGridViewKQ.Rows[i].Cells[2].Value.ToString());
            //    }
            //    for (int i = 0; i < dataGridViewKQ.Rows.Count - 1; i++)
            //    {
            //        dataGridViewKQ.Rows[i].Cells[3].Value = Math.Round((Convert.ToInt16(dataGridViewKQ.Rows[i].Cells[2].Value.ToString()) / tongdoanhthu), 3).ToString();
            //    }
            //}
         #endregion
        }
        #region cmt
//private bool CheckRules()
        //{
        //    QLCBRules _rule = new QLCBRules();
        //    if (!_rule.IsNNumber(comboBox_Nam.SelectedValue.ToString()) || comboBox_Nam.SelectedValue.ToString().Length > 4 || comboBox_Nam.SelectedValue.ToString() == "")
        //    {
        //        MessageBox.Show("Không ph?i là 1 nam!");
        //            return false;
        //    }
        //    int nam = Convert.ToInt16(comboBox_Nam.SelectedValue.ToString());
        //    if(nam < 2000 || nam > 2050)
        //    {
        //        MessageBox.Show("Nam ph?i thu?c 2000 t?i 2050!");
        //        return false;
        //    }
        //    return true;
        //}
#endregion

        private void buttonQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region cmt
//private void BaoCaoNam_FormClosing(object sender, FormClosingEventArgs e)
        //{

        //    if (e.CloseReason == CloseReason.WindowsShutDown) return;

        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        // Assume that X has been clicked and act accordingly.
        //        // Confirm user wants to close
        //        switch (MessageBox.Show(this, "B?n có mu?n d?ng vi?c l?p báo cáo nam không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        //        {

        //            case DialogResult.Yes:
        //                switch (BeCalledByForm)
        //                {
        //                    case "MAINFORM":
        //                        e.Cancel = false;
        //                        //                                 FormManager.CurrentBaoCaoNam = null;
        //                        //                                 FormManager.CurrentMainForm.Show();
        //                        break;
        //                }
        //                break;
        //            case DialogResult.No:
        //                e.Cancel = true;
        //                break;
        //        }
        //    }

        //}

        //private void buttonLuuTapTin_Click(object sender, EventArgs e)
        //{
        //    if (dataGridViewKQ.Rows.Count - 1 > 0)
        //    {
        //        ExportFile _file = new ExportFile();
        //        _file.ExportExcel(dataGridViewKQ);
        //    }
        //}
#endregion
    }
}
