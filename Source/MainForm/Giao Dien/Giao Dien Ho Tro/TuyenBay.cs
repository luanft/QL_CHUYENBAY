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
using MainForm.BusinessLogicLayer;

namespace MainForm
{
    public partial class TuyenBay : Form
    {
        private GiaoDienHoTroBLL _connect = new GiaoDienHoTroBLL();

        public static string TUYENBAY = "TUYENBAY";
        private string parentForm;
        //private TUYENBAY tuyenbaytemp = new TUYENBAY();
        //QLCBRules _rules = new QLCBRules();
        //public delegate void updateDB();
        //public updateDB CapNhatCSDL;
//         public string BeCalledByForm
//         {
//             get { return parentForm; }
//             set { parentForm = value; }
//         }
//         public string NAME
//         {
//             get { return TUYENBAY; }
//         }

        public TuyenBay()
        {
            InitializeComponent();
            UpdateData();
            textBoxMaTuyenBay.Text = AutoMaTuyenBay();
        }
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (CheckRule())
            {
                _connect.ThemTuyenBay(textBoxMaTuyenBay.Text, comboBoxSanBayDi.Text, comboBoxSanBayDen.Text);
            }
            textBoxMaTuyenBay.Text = AutoMaTuyenBay();
            UpdateData();
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                _connect.SuaTuyenBay(textBoxMaTuyenBay.Text, comboBoxSanBayDi.Text, comboBoxSanBayDen.Text);
                UpdateData(); 
            }
            catch (Exception ex) { }
        }
        private bool CheckRule()
        {
            if (comboBoxSanBayDi.Text == "" || comboBoxSanBayDen.Text == "")
            {
                MessageBox.Show("Sân bay đi và đến không thể để trống!");
                return false;
            }
            if (comboBoxSanBayDi.Text == comboBoxSanBayDen.Text)
            {

                MessageBox.Show("Sân bay đi đến không thể trùng nhau!");
                return false;
            }
            return true;
        }       
        private void _keydown(object sender, KeyEventArgs e)
        {
        }
        private string AutoMaTuyenBay()
        {
            return CreateMaTuyenBay(_connect.LayTuyenBay().Rows.Count + 1);

        }
        private string CreateMaTuyenBay(int k)
        {
            if (k >= 0 && k <= 9)
                return ("TB00" + k.ToString());
            if (k >= 10 && k <= 99)
                return ("TB0" + k.ToString());
            if (k >= 100 && k <= 999)
                return ("TB" + k.ToString());
            return "99999";

        }

        private void _btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void UpdateData()
        {
            this.datagrvTuyenBay.DataSource = _connect.LayTuyenBay();
            DataTable _t = _connect.LayMaSanBay();
            DataTable _t2 = _connect.LayMaSanBay();
            this.comboBoxSanBayDen.DataSource = _t;
            this.comboBoxSanBayDi.DataSource = _t2;
            this.comboBoxSanBayDen.ValueMember = "MaSanBay";
            this.comboBoxSanBayDi.ValueMember = "MaSanBay";
        }

        private void datagrvTuyenBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxMaTuyenBay.Text = this.datagrvTuyenBay.CurrentRow.Cells[0].Value.ToString();
            this.comboBoxSanBayDi.Text = this.datagrvTuyenBay.CurrentRow.Cells[1].Value.ToString();
            this.comboBoxSanBayDen.Text = this.datagrvTuyenBay.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
