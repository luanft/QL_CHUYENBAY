using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Linq;
using System.Data.SqlClient;
using MainForm.BusinessLogicLayer;
using System.Globalization;

namespace MainForm.Giao_diện.Bán_Vé___Đặt_Chỗ
{
    public partial class TraVe : Form
    {


        private TraVeBLL _travebll = new TraVeBLL();

        public TraVe()
        {
            InitializeComponent();
        }

        private void TraVe_Load(object sender, EventArgs e)
        {
            comboBox_mave.Items.Clear();
            // add item 
            comboBox_mave.Items.AddRange(_travebll.lay_danh_sach_ma_ve());
            // load data griidview
            dataGridView_thongtinve.DataSource = _travebll.lay_danh_sach_ve();
        }
        public void thong_bao_cho_nguoi_dung(string loi, int maloi)
        {
            label_thongbao.Visible = true;
            // nội dung
            label_thongbao.Text = loi;
            // xét màu
            switch (maloi)
            {
                case 1:// lưu không thành công, label thông báo chữ màu đỏ
                    {
                        label_thongbao.BackColor = Color.Red;
                        break;
                    }
                case 2: // lưu thành công, label thông báo chữ màu xanh
                    {
                        label_thongbao.BackColor = Color.Green;
                        break;
                    }
                default:
                    break;

            }

        }

        public bool ktra_du_lieu_hop_le()
        {

            if (comboBox_mave.Items.Contains(comboBox_mave.Text) == false)
            {

                label_mav.Visible = true;
                return false;
            }
            else
            {
                
                    label_mav.Visible = false;
                    return true;
                
            }
        }
        public bool ktra_ngay_tra_ve()
        {
                DateTime t = DateTime.ParseExact(_travebll.lay_ngay_khoi_hanh(textBox_macb.Text), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                DateTime tt = DateTime.ParseExact(textBox_giobay.Text, "hh:mm:ss", CultureInfo.InvariantCulture);
                DateTime now = DateTime.Now;
                //now=now.AddDays(+_datchobll.lay_quy_dinh_han_chot_dat_ve());
                if (t.Day <= now.Day && t.Month <= now.Month && t.Year <= now.Year && tt.Hour <= now.Hour && tt.Minute <= now.Minute && tt.Second <= now.Second)
                {
                   
                    return false;
                }
                else
                    return true;
                
        }
        public void xoa_all_du_lieu_texxtbox()
        {
            textBox_giatien.Text = null;
            textBox_giobay.Text = null;
            textBox_macb.Text = null;
            textBox_mahv.Text = null;
            textBox_ngay_bay.Text = null;
            textBox_SB_den.Text = null;
            textBox_SB_di.Text = null;
            textBox_scmnd.Text = null;
            textBox_sodt.Text = null;
            textBox_tenhangve.Text = null;
            textBox_tenhk.Text = null;
            textBox_Tgian_bay.Text = null;
            
        }
        private void comboBox_mave_TextChanged(object sender, EventArgs e)
        {
            if (ktra_du_lieu_hop_le() == true)
            {
                label_mav.Visible = false;
                Button_trave.Enabled = true;
                xoa_all_du_lieu_texxtbox();
                set_du_lieu_texxtbox_khi_select_combobox();
                label_thongbao.Visible = false;
            }
            else
            {
                label_mav.Visible = true;
                Button_trave.Enabled = false;
                
            }
        }

        public void set_du_lieu_texxtbox_khi_select_combobox()
        {
            
            textBox_macb.Text = _travebll.lay_macb(comboBox_mave.Text);
            textBox_tenhk.Text = _travebll.lay_tenhk(comboBox_mave.Text);
            textBox_sodt.Text = _travebll.lay_sdt(comboBox_mave.Text);
            textBox_scmnd.Text = _travebll.lay_cmnd(comboBox_mave.Text);
            textBox_mahv.Text = _travebll.lay_mahangve(comboBox_mave.Text);
            textBox_giatien.Text = _travebll.lay_giatien(comboBox_mave.Text);

        }

        private void textBox_macb_TextChanged(object sender, EventArgs e)
        {
            if (textBox_macb.Text.Trim().Length != 0)
            {
                textBox_SB_di.Text = _travebll.lay_thong_tin_san_bay_di(textBox_macb.Text);
                textBox_SB_den.Text = _travebll.lay_thong_tin_san_bay_den(textBox_macb.Text);
                textBox_Tgian_bay.Text = _travebll.lay_thoi_gian_bay(textBox_macb.Text);
                textBox_ngay_bay.Text = _travebll.lay_ngay_khoi_hanh(textBox_macb.Text);
                textBox_giobay.Text = _travebll.lay_gio_khoi_hanh(textBox_macb.Text);
            }
        }

        private void textBox_mahv_TextChanged(object sender, EventArgs e)
        {
            if (textBox_mahv.Text.Trim().Length != 0)
            {
                textBox_tenhangve.Text = _travebll.lay_ten_hang_ve(textBox_mahv.Text.ToString());
            }
        }

        private void Button_trave_Click(object sender, EventArgs e)
        {
            if(ktra_du_lieu_hop_le()==true)
            {
                if (ktra_ngay_tra_ve() == true)
                {
                    _travebll.xoa(comboBox_mave.Text, textBox_macb.Text, textBox_mahv.Text);
                    // thong bao cho nguoi dung
                    thong_bao_cho_nguoi_dung("Đã xóa vé thành công", 2);
                    // load data griidview
                    dataGridView_thongtinve.DataSource = _travebll.lay_danh_sach_ve();
                    xoa_all_du_lieu_texxtbox();
                    // xoa texxt ccombobox & reload item combobox
                    comboBox_mave.Items.Clear();
                    // add item 
                    comboBox_mave.Items.AddRange(_travebll.lay_danh_sach_ma_ve());
                    comboBox_mave.Text = null;
                }
                else
                {
                    thong_bao_cho_nguoi_dung("Không thể trả vé trên chuyến bay đã cất cánh!", 1);
                }
            }
            else
            {
                thong_bao_cho_nguoi_dung("Mã vé không tồn tại !", 1);
            }
        }

        private void dataGridView_thongtinve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row != -1)
            {
                comboBox_mave.Text = dataGridView_thongtinve.Rows[row].Cells[1].Value.ToString();
            }
        }

    }
}

