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

namespace MainForm.Giao_Dien.Tra_Cuu
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
        

        private void LichBay_Load(object sender, EventArgs e)
        {
            dataGridViewKQ.DataSource = bll.LayDanhSachChuyenBay();

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.LayChuyenBay(txtMaChuyenBay.Text);
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Không tìm thấy chuyến bay này");
                return;
            }
            dataGridViewKQ.DataSource = dt;
        }

       
    
       
    

    }
}
