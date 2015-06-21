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
    public partial class TraCuuLichBay : Form
    {
        //QLCBDataContext db = new QLCBDataContext();
        //QLCBRules _rule = new QLCBRules();
        BusinessLogicLayer.TraCuuLichBayBLL bll = new BusinessLogicLayer.TraCuuLichBayBLL();
        // fields
        public static string LICHBAY = "LICHBAY";
        private string _parentForm;

        // properties
        public string BeCalledByForm
        {
            get { return _parentForm; }
            set { _parentForm = value; }
        }
        public string NAME
        {
            get { return LICHBAY; }
        }

        // constructor
        public TraCuuLichBay()
        {
            InitializeComponent();
            setDateTimePickerFormat(dateTimePickerCuoi);
            setDateTimePickerFormat(dateTimePickerDau);
            InitAllCombobox();
            comboBoxSanBayDen.Enabled = false;
            comboBoxSanBayDi.Enabled = false;
            dateTimePickerCuoi.Text = "";
            dateTimePickerDau.Text = "";
            
        }

        private void setDateTimePickerFormat(DateTimePicker dt)
        {
            dt.Format = DateTimePickerFormat.Custom;
            dt.CustomFormat = "dd/MM/yyyy";
        }

        private void buttonQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LichBay_FormClosing(object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Assume that X has been clicked and act accordingly.
                // Confirm user wants to close
                switch (MessageBox.Show(this, "Bạn có muốn dừng việc tra cứu không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    case DialogResult.Yes:
                        switch (BeCalledByForm)
                        {
                            case "MAINFORM":
                                e.Cancel = false;

//                                 FormManager.CurrentLichBay = null;
//                                 FormManager.CurrentMainForm.Show();
                                break;
                        }
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                }
            }
        }
        private void UpdateDatagridviewWithDateTime()
        {
            for (int i = 0; i < dataGridViewKQ.Rows.Count; i++)
            {
                if (!dataGridViewKQ.Rows[i].IsNewRow)
                {
                    if (Convert.ToDateTime(dataGridViewKQ.Rows[i].Cells[4].Value.ToString()) < dateTimePickerDau.Value ||
                        Convert.ToDateTime(dataGridViewKQ.Rows[i].Cells[4].Value.ToString()) > dateTimePickerCuoi.Value)
                    {
                        dataGridViewKQ.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        private void LichBay_Load(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void InitAllCombobox()
        {
            
            //Table<CHUYENBAY> chuyenbays = db.GetTable<CHUYENBAY>();
            //Table<SANBAY> sanbays = db.GetTable<SANBAY>();

            comboBoxMaChuyenBay.ResetText();
            comboBoxSanBayDen.ResetText();
            comboBoxSanBayDi.ResetText();

            comboBoxMaChuyenBay.Items.Clear();
            comboBoxSanBayDen.Items.Clear();
            comboBoxSanBayDi.Items.Clear();

            comboBoxMaChuyenBay.Items.Add("Tìm Theo Sân Bay");
            comboBoxMaChuyenBay.Items.Add("Tìm theo Ngày khởi hành");
            DataTable danhSachMaChuyenBay = bll.LayDanhSachMaChuyenBay();
            for (int i = 0; i < danhSachMaChuyenBay.Rows.Count; i++ )
            {
                comboBoxMaChuyenBay.Items.Add(danhSachMaChuyenBay.Rows[i][0]);
                
            }

            comboBoxSanBayDen.Items.Add("Tìm theo chuyến bay");
            comboBoxSanBayDi.Items.Add("Tìm theo chuyến bay");
            comboBoxSanBayDi.Items.Add("Tìm theo Ngày khởi hành");
            comboBoxSanBayDen.Items.Add("Tìm theo Ngày khởi hành");
            comboBoxSanBayDen.Items.Add("Tìm theo Ngày khởi hành và Tên sân bay đến");
            DataTable danhSachSanBay= bll.LayDanhSachSanBay();
            for (int i = 0; i < danhSachSanBay.Rows.Count; i++) 
            {
                comboBoxSanBayDen.Items.Add(danhSachSanBay.Rows[i][1]);
                comboBoxSanBayDi.Items.Add(danhSachSanBay.Rows[i][1]);
            }
            

        }

        private void comboBoxMaChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMaChuyenBay.SelectedIndex == 0)
            {
                comboBoxMaChuyenBay.Enabled = false;
                comboBoxSanBayDen.ResetText();
                comboBoxSanBayDi.ResetText();
                comboBoxSanBayDen.Enabled = true;
                comboBoxSanBayDi.Enabled = true;
                dateTimePickerDau.Enabled = false;
                dateTimePickerCuoi.Enabled = false;
            }
            else if(comboBoxMaChuyenBay.SelectedIndex==1)
            {
                
                comboBoxSanBayDen.ResetText();
                comboBoxSanBayDi.ResetText();
                comboBoxSanBayDen.Enabled = false;
                comboBoxSanBayDi.Enabled = false;
                dateTimePickerDau.Enabled = true;
                dateTimePickerCuoi.Enabled = true;
            }
            else
            {
                dateTimePickerDau.Enabled = false;
                dateTimePickerCuoi.Enabled = false;
                comboBoxSanBayDen.Enabled = false;
                comboBoxSanBayDi.Enabled = false;
                //cả đoạn dưới được thay bằng câu này
                dataGridViewKQ.DataSource = bll.LayChuyenBay(comboBoxMaChuyenBay.Text);

                //Table<CHUYENBAY> chuyenbays = db.GetTable<CHUYENBAY>();

                //CHUYENBAY chuyenbaytemp = chuyenbays.Single(p => p.MaChuyenBay == comboBoxMaChuyenBay.Text);

                //Table<TUYENBAY> tuyenbays = db.GetTable<TUYENBAY>();
                //TUYENBAY tuyenbaytemp = tuyenbays.Single(p => p.MaTuyenBay == chuyenbaytemp.MaTuyenBay);

                //Table<SANBAY> sanbays = db.GetTable<SANBAY>();
                //SANBAY sanbayditemp = sanbays.Single(p => p.MaSanBay == tuyenbaytemp.MaSanBayDi);
                //comboBoxSanBayDi.Text = sanbayditemp.TenSanBay + " (" + sanbayditemp.MaSanBay + ")";

                //SANBAY sanbaydentemp = sanbays.Single(p => p.MaSanBay == tuyenbaytemp.MaSanBayDen);
                //comboBoxSanBayDen.Text = sanbaydentemp.TenSanBay + " (" + sanbaydentemp.MaSanBay + ")";

                //Table<CTGHE> ctg = db.GetTable<CTGHE>();
                //var ctgs = from e1 in ctg
                //           where(e1.MaChuyenBay == comboBoxMaChuyenBay.Text)
                //           select e1;

                //int gtrong = 0;
                //int gdat = 0;
                //foreach(var k in ctgs)
                //{
                //    gtrong += Convert.ToInt16(k.SoGheTrong);
                //    gdat +=  Convert.ToInt16(k.SoGheDat);
                //}
                //dataGridViewKQ.Rows.Clear();
                //dataGridViewKQ.Rows.Add
                //    (
                //    "1",
                //    chuyenbaytemp.MaChuyenBay,
                //    sanbayditemp.TenSanBay,
                //    sanbaydentemp.TenSanBay,
                //    chuyenbaytemp.NgayKhoiHanh.Value.ToShortDateString(),
                //    chuyenbaytemp.GioKhoiHanh.Value.ToString("HH:mm:ss"),
                //    chuyenbaytemp.ThoiGianBay,
                //    gtrong.ToString(),
                //    gdat.ToString()
                //    );

            }

        }

        private void comboBoxSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chon theo ma chuyen bay
            if (comboBoxSanBayDi.SelectedIndex == 0)
            {
                comboBoxSanBayDi.Enabled = false;
                comboBoxSanBayDen.Enabled = false;
                comboBoxMaChuyenBay.Enabled = true;
                comboBoxMaChuyenBay.ResetText();
                dateTimePickerDau.Enabled = false;
                dateTimePickerCuoi.Enabled = false;
            }
            else if(comboBoxSanBayDi.SelectedIndex==1)
            {
                comboBoxMaChuyenBay.Enabled = false;
                //comboBoxSanBayDi.Enabled = false;
                comboBoxSanBayDen.Enabled = false;
                //comboBoxSanBayDen.Enabled = false;
                comboBoxMaChuyenBay.ResetText();
                comboBoxSanBayDi.ResetText();
                comboBoxSanBayDen.ResetText();
                dateTimePickerDau.Enabled = true;
                dateTimePickerCuoi.Enabled = true;
            }
            else
            {
                dateTimePickerDau.Enabled = false;
                dateTimePickerCuoi.Enabled = false;
                if (comboBoxSanBayDen.Text == "" )
                {
                    DataTable dt = bll.LayChuyenBay_theoSBdi(comboBoxSanBayDi.Text);
                    dataGridViewKQ.DataSource = dt;
                    //TheoSBDi();
                    //UpdateDatagridviewWithDateTime();
                }
                else
                {
                    //TheoSBdi_den();
                    //UpdateDatagridviewWithDateTime();
                    DataTable dt = bll.LayChuyenBay_theoSBdenvadi(comboBoxSanBayDi.Text, comboBoxSanBayDen.Text);
                    dataGridViewKQ.DataSource = dt;
                }
                


            }
        }

        private void comboBoxSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSanBayDen.SelectedIndex == 0)
            {
                comboBoxSanBayDi.Enabled = false;
                comboBoxSanBayDen.Enabled = false;
                comboBoxMaChuyenBay.Enabled = true;
                comboBoxMaChuyenBay.ResetText();
                dateTimePickerDau.Enabled = false;
                dateTimePickerCuoi.Enabled = false;
            }
            else if(comboBoxSanBayDen.SelectedIndex==1)
            {
                comboBoxMaChuyenBay.Enabled = false;
                //comboBoxSanBayDen.Enabled = false;
                comboBoxSanBayDi.Enabled = false;
                comboBoxSanBayDi.ResetText();
                comboBoxSanBayDen.ResetText();
                comboBoxMaChuyenBay.ResetText();
                dateTimePickerDau.Enabled = true;
                dateTimePickerCuoi.Enabled = true;
            }
            else if(comboBoxSanBayDen.SelectedIndex ==2)
            {
                comboBoxMaChuyenBay.Enabled = false;
                comboBoxSanBayDen.Enabled = true;
                comboBoxSanBayDi.Enabled = false;
                comboBoxSanBayDi.ResetText();
                comboBoxSanBayDen.ResetText();
                comboBoxMaChuyenBay.ResetText();
                dateTimePickerDau.Enabled = true;
                dateTimePickerCuoi.Enabled = true;
                comboBoxSanBayDen.Text = "";
                dataGridViewKQ.DataSource = null;
                for (int i = 0; i < dataGridViewKQ.Rows.Count-1; i++)
                {

                    dataGridViewKQ.Rows.RemoveAt(i);

                }
            }
            else
            {
                
                if (comboBoxSanBayDi.Text == "" && dateTimePickerDau.Enabled == false && dateTimePickerCuoi.Enabled == false )
                {
                    DataTable dt = bll.LayChuyenBay_theoSBden(comboBoxSanBayDi.Text);
                    
                    //TheoSBDen();
                    //UpdateDatagridviewWithDateTime();

                }
                else if(comboBoxSanBayDi.Text!="")
                {
                    dataGridViewKQ.DataSource = bll.LayChuyenBay_theoSBdenvadi(comboBoxSanBayDi.Text, comboBoxSanBayDen.Text);
                    //TheoSBdi_den();
                    //UpdateDatagridviewWithDateTime();
                }
                else
                {
                    
                }

            }
        }

        /*private void TheoSBDi()
        {
            string MaSB = _rule.StrCut(comboBoxSanBayDi.Text, comboBoxSanBayDi.Text.Length - 6, comboBoxSanBayDi.Text.Length - 2);
            dataGridViewKQ.Rows.Clear();
            Table<TUYENBAY> tuyenbays = db.GetTable<TUYENBAY>();
            Table<CHUYENBAY> chuyenbays = db.GetTable<CHUYENBAY>();
            int stt = 0;
            foreach (var cb in chuyenbays)
            {
                foreach(var tb in tuyenbays)
                    if (tb.MaSanBayDi == MaSB && tb.MaTuyenBay == cb.MaTuyenBay)
                    {
                        int trong = 0;
                        int dat = 0;
                        Table<CTGHE> ctg = db.GetTable<CTGHE>();
                        var ctgs = from ct in ctg
                                   where(ct.MaChuyenBay == cb.MaChuyenBay)
                                   select ct;
                        foreach(var ctt in ctgs)
                        {
                            trong += Convert.ToInt16(ctt.SoGheTrong);
                            dat += Convert.ToInt16(ctt.SoGheDat);
                        }
                        dataGridViewKQ.Rows.Add
                            (
                            stt.ToString(),
                            cb.MaChuyenBay,
                            LayTenSB(tb.MaSanBayDi),
                            LayTenSB(tb.MaSanBayDen),
                            cb.NgayKhoiHanh.Value.ToShortDateString(),
                            cb.GioKhoiHanh.Value.ToString("HH:mm:ss"),
                            cb.ThoiGianBay.ToString(),
                            trong.ToString(),
                            dat.ToString()
                            );
                        stt += 1;
                    }
                        
            }
        }*/

        /*private string LayTenSB(string _masanbay)
        {
            Table<SANBAY> sanbays = db.GetTable<SANBAY>();
            SANBAY temp = sanbays.Single(p => p.MaSanBay == _masanbay);
            return temp.TenSanBay;
        }
        private void TheoSBDen()
        {
            string MaSB = _rule.StrCut(comboBoxSanBayDen.Text, comboBoxSanBayDen.Text.Length - 6, comboBoxSanBayDen.Text.Length - 2);
            dataGridViewKQ.Rows.Clear();
            Table<TUYENBAY> tuyenbays = db.GetTable<TUYENBAY>();
            Table<CHUYENBAY> chuyenbays = db.GetTable<CHUYENBAY>();
            int stt = 0;
            foreach (var cb in chuyenbays)
            {
                foreach (var tb in tuyenbays)
                    if (tb.MaSanBayDen == MaSB && tb.MaTuyenBay == cb.MaTuyenBay)
                    {
                        int trong = 0;
                        int dat = 0;
                        Table<CTGHE> ctg = db.GetTable<CTGHE>();
                        var ctgs = from ct in ctg
                                   where (ct.MaChuyenBay == cb.MaChuyenBay)
                                   select ct;
                        foreach (var ctt in ctgs)
                        {
                            trong += Convert.ToInt16(ctt.SoGheTrong);
                            dat += Convert.ToInt16(ctt.SoGheDat);
                        }
                        dataGridViewKQ.Rows.Add
                            (
                            stt.ToString(),
                            cb.MaChuyenBay,
                            LayTenSB(tb.MaSanBayDi),
                            LayTenSB(tb.MaSanBayDen),
                            cb.NgayKhoiHanh.Value.ToShortDateString(),
                            cb.GioKhoiHanh.Value.ToString("HH:mm:ss"),
                            cb.ThoiGianBay.ToString(),
                            trong.ToString(),
                            dat.ToString()
                            );
                        stt += 1;
                    }
            }
        }
        private void TheoSBdi_den()
        {
            string MaSBdi = _rule.StrCut(comboBoxSanBayDi.Text, comboBoxSanBayDi.Text.Length - 6, comboBoxSanBayDi.Text.Length - 2);
            string MaSBden = _rule.StrCut(comboBoxSanBayDen.Text, comboBoxSanBayDen.Text.Length - 6, comboBoxSanBayDen.Text.Length - 2);
            int stt = 0;
            dataGridViewKQ.Rows.Clear();
            Table<TUYENBAY> tuyenbays = db.GetTable<TUYENBAY>();
            var dstuyenbay = from e in tuyenbays
                             where (e.MaSanBayDi == MaSBdi && e.MaSanBayDen == MaSBden)
                             select e;
            Table<CHUYENBAY> chuyenbays = db.GetTable<CHUYENBAY>();
            foreach (var cb in chuyenbays)
            {
                foreach(var tb in dstuyenbay)
                    if (tb.MaTuyenBay == cb.MaTuyenBay)
                    {
                        int trong = 0;
                        int dat = 0;
                        Table<CTGHE> ctg = db.GetTable<CTGHE>();
                        var ctgs = from ct in ctg
                                   where (ct.MaChuyenBay == cb.MaChuyenBay)
                                   select ct;
                        foreach (var ctt in ctgs)
                        {
                            trong += Convert.ToInt16(ctt.SoGheTrong);
                            dat += Convert.ToInt16(ctt.SoGheDat);
                        }
                        dataGridViewKQ.Rows.Add(
                            stt.ToString(),
                            cb.MaChuyenBay,
                            LayTenSB(tb.MaSanBayDi),
                            LayTenSB(tb.MaSanBayDen),
                            cb.NgayKhoiHanh.Value.ToShortTimeString(),
                            cb.GioKhoiHanh.Value.ToString("HH:mm:ss"),
                            cb.ThoiGianBay.ToString(),
                            trong.ToString(),
                            dat.ToString()
                            );
                        stt++;
                    }
            }
        }*/
        private void buttonXuatTapTin_Click(object sender, EventArgs e)
        {
            if (dataGridViewKQ.Rows.Count - 1 > 0)
            {
                ExportFile _file = new ExportFile();
                _file.ExportExcel(dataGridViewKQ);
            }
            else
            {
                MessageBox.Show("Không có dòng nào để xuất!");
            } 
        }

        private void dateTimePickerDau_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePickerCuoi.Text=="")
            {
                return;
            }
            if (comboBoxSanBayDen.Text == "Tìm theo Ngày khởi hành" || comboBoxSanBayDi.Text == "Tìm theo Ngày khởi hành" || comboBoxMaChuyenBay.Text == "Tìm theo Ngày khởi hành") 
            {
                dataGridViewKQ.DataSource = bll.LayChuyenBay_theoNgay(dateTimePickerDau.Text, dateTimePickerCuoi.Text);
            }
            else
            {
                if (comboBoxSanBayDen.SelectedIndex != 1)
                    dataGridViewKQ.DataSource = bll.LayChuyenBay_theoSBden_NgayKhoiHanh(comboBoxSanBayDen.Text, dateTimePickerDau.Text, dateTimePickerCuoi.Text);
            }
        }

        private void dateTimePickerCuoi_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerDau.Text == "")
            {
                return;
            }
            if (comboBoxSanBayDen.Text == "Tìm theo Ngày khởi hành" || comboBoxSanBayDi.Text == "Tìm theo Ngày khởi hành" || comboBoxMaChuyenBay.Text == "Tìm theo Ngày khởi hành")
            {
                dataGridViewKQ.DataSource = bll.LayChuyenBay_theoNgay(dateTimePickerDau.Text, dateTimePickerCuoi.Text);
            }
            else
            {
                if (comboBoxSanBayDen.SelectedIndex != 1)
                    dataGridViewKQ.DataSource = bll.LayChuyenBay_theoSBden_NgayKhoiHanh(comboBoxSanBayDen.Text, dateTimePickerDau.Text, dateTimePickerCuoi.Text);
            }
        }

    }
}
