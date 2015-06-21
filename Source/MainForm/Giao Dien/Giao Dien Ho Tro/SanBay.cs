using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;
using MainForm.BusinessLogicLayer;

namespace MainForm
{
    public partial class SanBay : Form
    {
        private GiaoDienHoTroBLL _connect = new GiaoDienHoTroBLL();
        public static string SANBAY = "SANBAY";
        private string parentForm;                
        private bool isSelectOneRows = false;

        public string BeCalledByForm
        {
            get { return parentForm; }
            set { parentForm = value; }
        }
        public string NAME
        {
            get { return SANBAY; }
        }

        public SanBay()
        {
            InitializeComponent();
            this.textBoxMaSanBay.Text = AutoMaSanBay();
            updateDataGrid();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                _connect.SuaSanBay(textBoxMaSanBay.Text, textBoxTenSanBay.Text, textBoxDiaChiSanBay.Text);
                updateDataGrid();
            }
            catch (Exception ex) { }
        }              
        private void buttonLuu_Click_1(object sender, EventArgs e)
        {
            if (CheckRules())
            {
                _connect.ThemSanBay(textBoxMaSanBay.Text, textBoxTenSanBay.Text, textBoxDiaChiSanBay.Text);
            }
            textBoxMaSanBay.Text = AutoMaSanBay();
            updateDataGrid();
        }
        private void _KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && isSelectOneRows)
            {
                
            }
        }

        private void dataGridViewSanBayDaThem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxMaSanBay.Text = this.dataGridViewSanBayDaThem.CurrentRow.Cells[0].Value.ToString();
            this.textBoxTenSanBay.Text = this.dataGridViewSanBayDaThem.CurrentRow.Cells[1].Value.ToString();
            this.textBoxDiaChiSanBay.Text = this.dataGridViewSanBayDaThem.CurrentRow.Cells[2].Value.ToString();

        }
        private bool CheckRules()
        {
            if (textBoxDiaChiSanBay.Text == "" || textBoxTenSanBay.Text == "")
            {
                MessageBox.Show("Không thể để trống địa chỉ sân bay và tên sân bay!");
                return false;
            }            
            return true;
        }
        private string AutoMaSanBay()
        {
            int n = _connect.LaySanBay().Rows.Count;
            return HamTaoLao(n+1);
        }
        private string HamTaoLao(int k)
        {
            if (k >= 0 && k <= 9)
                return ("SB00" + k.ToString());
            if (k >= 10 && k <= 99)
                return ("SB0" + k.ToString());
            if (k >= 100 && k <= 999)
                return ("SB" + k.ToString());
            return "99999";

        }        
        private void InitDefaultState()
        {            
        }
        private void updateDataGrid()
        {
            this.dataGridViewSanBayDaThem.DataSource = _connect.LaySanBay();
        }       
    }
}
