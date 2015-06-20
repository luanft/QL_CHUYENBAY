using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainForm.BusinessLogicLayer;

namespace MainForm.Giao_Dien.Giao_Dien_Ho_Tro
{
    public partial class ThemNguoiDung : Form
    {
        HeThongBLL bll = new HeThongBLL();
        public ThemNguoiDung()
        {
            InitializeComponent();
        }

        private void ThemNguoiDung_Load(object sender, EventArgs e)
        {
            txt_maNhanVien.Text = bll.TaoMaNhanVienTiepTheo();
            cb_chucVu.DataSource = bll.DanhSachNhomNguoiDung();
            cb_chucVu.DisplayMember = "TenNhomNguoiDung";
            cb_chucVu.ValueMember = "MaNhomNguoiDung";
            cb_chucVu.SelectedIndex = 2;
            txt_hoTen.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool KiemTraDieuKienNhap()
        {
            if (txt_hoTen.Text == "")
            {
                txt_hoTen.Focus();
                lb_thongBao.Text = "* Bạn phải nhập họ tên!";
                return false;
            }

            if (txt_email.Text == "")
            {
                txt_email.Focus();
                lb_thongBao.Text = "* Bạn phải nhập email!";
                return false;
            }
            if (cb_chucVu.SelectedValue == null)
            {
                cb_chucVu.Focus();
                lb_thongBao.Text = "* Bạn chưa chọn chức vụ!";
                return false;
            }
            return true;
        }

        private void btn_themNhanVien_Click(object sender, EventArgs e)
        {
            if (KiemTraDieuKienNhap())
            {                
                bll.ThemNhanVien(txt_maNhanVien.Text.Trim(), txt_hoTen.Text,"123456", txt_email.Text);
                bll.ThemChucVuChoNhanVien(txt_maNhanVien.Text.Trim(), cb_chucVu.SelectedValue.ToString().Trim());
                txt_maNhanVien.Text = bll.TaoMaNhanVienTiepTheo();
                txt_hoTen.Text = "";
                txt_email.Text = "";
                cb_chucVu.SelectedIndex = 2;
                lb_thongBao.Text = "Đã thêm!";
                txt_hoTen.Focus();
            }            
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (KiemTraDieuKienNhap())
                {
                    lb_thongBao.Text = "";
                    bll.ThemNhanVien(txt_maNhanVien.Text, txt_hoTen.Text, "123456", txt_email.Text);
                    bll.ThemChucVuChoNhanVien(txt_maNhanVien.Text, cb_chucVu.SelectedValue.ToString().Trim());
                    txt_maNhanVien.Text = bll.TaoMaNhanVienTiepTheo();
                    txt_hoTen.Text = "";
                    txt_email.Text = "";
                    cb_chucVu.SelectedIndex = 2;
                    lb_thongBao.Text = "Đã thêm!";
                    txt_hoTen.Focus();
                }            
            }
        }
    }
}
