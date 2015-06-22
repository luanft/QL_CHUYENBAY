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
        QLCBRules _rules = new QLCBRules();
        public delegate void updateDB();
        public updateDB CapNhatCSDL;
        public string BeCalledByForm
        {
            get { return parentForm; }
            set { parentForm = value; }
        }
        public string NAME
        {
            get { return TUYENBAY; }
        }

        public TuyenBay()
        {
            InitializeComponent();
            UpdateData();
            textBoxMaTuyenBay.Text = AutoMaTuyenBay();
            DataTable _t = _connect.LayMaSanBay();
            this.comboBoxSanBayDi.DataSource = _t;
            this.comboBoxSanBayDi.ValueMember = "MaSanBay";
            DataTable _t2 = _connect._LayMaSanBay();
            this.comboBoxSanBayDen.DataSource = _t2;
            this.comboBoxSanBayDi.ValueMember = "MaSanBay";
            DataTable _a = _connect.TenSanBay("SB001");
            DataTable _b = _connect.TenSanBay("SB002");            
            _ctenden.DataSource =_b;
            _ctenden.ValueMember = "TenSanBay";
            _ctendi.DataSource = _a;
            _ctendi.ValueMember = "TenSanBay";
        }
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (_connect.kiemtratuyenbay(comboBoxSanBayDi.Text, comboBoxSanBayDen.Text) == false)
            { 
                MessageBox.Show("Tuyến bay này đã tồn tại");
                return;
            }
            if (CheckRule())
            {
                _connect.ThemTuyenBay(textBoxMaTuyenBay.Text, comboBoxSanBayDi.Text, comboBoxSanBayDen.Text);
            }
            textBoxMaTuyenBay.Text = AutoMaTuyenBay();
            UpdateData();
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
        }

        private void datagrvTuyenBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxMaTuyenBay.Text = this.datagrvTuyenBay.CurrentRow.Cells[0].Value.ToString();
            this.comboBoxSanBayDi.Text = this.datagrvTuyenBay.CurrentRow.Cells[1].Value.ToString();
            this.comboBoxSanBayDen.Text = this.datagrvTuyenBay.CurrentRow.Cells[2].Value.ToString();
        }        
        private void comboBoxSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
                     
            DataTable _t2 = _connect.LayMaSanBay(comboBoxSanBayDi.Text);
            this.comboBoxSanBayDen.DataSource = _t2;
            this.comboBoxSanBayDen.ValueMember = "MaSanBay";
            DataTable _a = _connect.TenSanBay(comboBoxSanBayDi.Text);
            DataTable _b = _connect.TenSanBay(comboBoxSanBayDen.Text);
            _ctendi.DataSource = _a;
            _ctendi.ValueMember = "TenSanBay";
            _ctenden.DataSource = _b;
            _ctenden.ValueMember = "TenSanBay";
        }

        private void _ctenden_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable _a = _connect.TenSanBay(comboBoxSanBayDi.Text);
            DataTable _b = _connect.TenSanBay(comboBoxSanBayDen.Text);
            _ctendi.DataSource = _a;
            _ctendi.ValueMember = "TenSanBay";
            _ctenden.DataSource = _b;
            _ctenden.ValueMember = "TenSanBay";
        }

        private void _btSua_Click(object sender, EventArgs e)
        {
            try
            {
                _connect.SuaTuyenBay(textBoxMaTuyenBay.Text, comboBoxSanBayDi.Text, comboBoxSanBayDen.Text);
                UpdateData();
            }
            catch (Exception ex) { }
            textBoxMaTuyenBay.Text = AutoMaTuyenBay();

        }       
    }
}
