using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainForm.Giao_Dien.Tra_Cuu
{
    public partial class DuLieu : Form
    {
        DataAccessLayer.DuLieuDAL dal = new DataAccessLayer.DuLieuDAL();
        public DuLieu()
        {
            InitializeComponent();
        }

        private void cbLoai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /* 1 Nhân viên
            *  2 Nhóm người dùng
            *  3 Tuyến bay
            *  4 Phiếu đặt chổ
            *  5 Vé
            *  6 Quyền hạn
            *  7 Sân Bay
            *  8 Hang vé
            *  9 Tham số 
            */
            switch( cbLoai.SelectedIndex)
            {
                case 0: dgvDuLieu.DataSource = dal.LayDanhSachNhanVien(); break;
                case 1: dgvDuLieu.DataSource = dal.LayDanhSachNhomNguoiDung(); break;
                case 2: dgvDuLieu.DataSource = dal.LayDanhSachTuyenBay(); break;
                case 3: dgvDuLieu.DataSource = dal.LayDanhSachPhieuDatCho(); break;
                case 4: dgvDuLieu.DataSource = dal.LayDanhSachVe(); break;
                case 5: dgvDuLieu.DataSource = dal.LayDanhSachQuyenHan(); break;
                case 6: dgvDuLieu.DataSource = dal.LayDanhSachSanBay(); break;
                case 7: dgvDuLieu.DataSource = dal.LayDanhSachHangVe(); break;
                case 8: dgvDuLieu.DataSource = dal.LayDanhSachThamSo(); break;
                    
            }
        }
    }
}
