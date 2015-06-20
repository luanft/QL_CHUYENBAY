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
    public partial class PhanQuyen : Form
    {
        HeThongBLL bll;
        bool loaded = false;
        public PhanQuyen()
        {
            InitializeComponent();
        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            loaded = false;
            bll = new HeThongBLL();
            cb_nhomNguoiDung.DataSource = bll.DanhSachNhomNguoiDung();
            cb_nhomNguoiDung.DisplayMember = "TenNhomNguoiDung";
            cb_nhomNguoiDung.ValueMember = "MaNhomNguoiDung";
            cb_nhomNguoiDung.SelectedIndex = 1;
            loaded = true;
            cb_nhomNguoiDung.SelectedIndex--;            
        }

        private void cb_nhomNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                dt_danhSachQuyen.DataSource = bll.NhomChucNang(cb_nhomNguoiDung.SelectedValue.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow i in dt_danhSachQuyen.Rows)
            {

                    if (i.Cells["SuDung"].Value.ToString().Trim().ToLower() == "true")
                    {
                        try
                        {
                            bll.ThemQuyen(i.Cells["MaChucNang"].Value.ToString().Trim(), cb_nhomNguoiDung.SelectedValue.ToString().Trim());
                        }
                        catch (Exception ee)
                        {

                        }
                    }
                    else
                    {
                        bll.XoaQuyen(i.Cells["MaChucNang"].Value.ToString().Trim(), cb_nhomNguoiDung.SelectedValue.ToString().Trim());
                    }
                }             
            
            MessageBox.Show("Đã cập nhật!");
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txt_maNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!bll.KiemTraSuTonTaiNguoiDung(txt_maNhanVien.Text))
            {
                MessageBox.Show("Mã nhân viên này không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);                 
            }
            DataTable data = bll.LayCacChucVuNhanVien(txt_maNhanVien.Text);
            dt_quyenNguoiDung.DataSource = data;                             
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            if (!bll.KiemTraSuTonTaiNguoiDung(txt_maNhanVien.Text))
            {
                MessageBox.Show("Mã nhân viên này không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (DataGridViewRow i in dt_quyenNguoiDung.Rows)
            {
                if (i.Cells["SU_DUNG"].Value.ToString().ToLower() == "true")
                {
                    //them quyen ơ day
                    try
                    {
                        bll.ThemChucVuChoNhanVien(txt_maNhanVien.Text, i.Cells["MaNhomNguoiDung"].Value.ToString());
                    }
                    catch (Exception ee)
                    {
                    }                    
                }
                else
                {
                    //xoa quyen
                    bll.XoaChucVuNhanVien(txt_maNhanVien.Text, i.Cells["MaNhomNguoiDung"].Value.ToString());
                }
            }
            MessageBox.Show("Đã cập nhật", "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
