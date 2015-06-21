using MainForm.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Giao_diện
{
    public partial class HangVe : Form
    {
        GiaoDienHoTroBLL _connect = new GiaoDienHoTroBLL();

        private string _parrentForm;                        
        public string BeCalledByForm
        {
            get { return _parrentForm; }
            set { _parrentForm = value; }
        }
        public HangVe()
        {
            InitializeComponent();
            updateDataGrid();
            this.textBoxMaHangVe.Text = AutoMaHangVe();
        }                        
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (CheckRules())
            {                
                _connect.ThemHangVe(this.textBoxMaHangVe.Text, this.textBoxTenHangVe.Text, float.Parse(this.textBoxTiLeDonGia.Text));
            }
            this.textBoxMaHangVe.Text = AutoMaHangVe();
            this.textBoxTenHangVe.Text = "";
            this.textBoxTiLeDonGia.Text = "1.0";
            updateDataGrid();
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                _connect.SuaHangVe(textBoxMaHangVe.Text, textBoxTenHangVe.Text, float.Parse(textBoxTiLeDonGia.Text));
                updateDataGrid();
            }
            catch (Exception ex) {
            
            }
        }                         
        private bool CheckRules()
        {
            if (textBoxTenHangVe.Text == "" || textBoxTiLeDonGia.Text == "")
            {
                MessageBox.Show("Không thể để trống thông tin!");
                return false;
            }
            QLCBRules _rule = new QLCBRules();
            if (!_rule.IsFNumber(textBoxTiLeDonGia.Text))
            {
                MessageBox.Show("Tỉ lệ đơn giá phải là số!");
                return false;
            }
            if (Convert.ToDouble(textBoxTiLeDonGia.Text) < 0.0f)
            {
                MessageBox.Show("Tỉ lệ đơn giá không thể âm!");
                return false;
            }            
            return true;

        }
        private string AutoMaHangVe()
        {            
            int n = _connect.LayHangVe().Rows.Count;
            return HamTaoLao(n+1);
        }
        private string HamTaoLao(int k)
        {
            if (k >= 0 && k <= 9)
                return ("HV00" + k.ToString());
            if (k >= 10 && k <= 99)
                return ("HV0" + k.ToString());
            if (k >= 100 && k <= 999)
                return ("HV" + k.ToString());
            return "99999";

        }        
        private void _btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewHangVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxMaHangVe.Text = this.dataGridViewHangVe.CurrentRow.Cells[0].Value.ToString();
            this.textBoxTenHangVe.Text = this.dataGridViewHangVe.CurrentRow.Cells[1].Value.ToString();
            this.textBoxTiLeDonGia.Text = this.dataGridViewHangVe.CurrentRow.Cells[2].Value.ToString();
        }
        public void updateDataGrid()
        {
            this.dataGridViewHangVe.DataSource = _connect.LayHangVe();
        }
    }
}
