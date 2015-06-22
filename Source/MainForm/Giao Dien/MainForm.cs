using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForm.BusinessLogicLayer;
using MainForm.Giao_diện;
using MainForm.Giao_diện.Bán_Vé___Đặt_Chỗ;
using MainForm.Giao_diện.Giao_Diện_Hỗ_Trợ;
using MainForm.Giao_Dien.Giao_Dien_Ho_Tro;

namespace MainForm
{
    public partial class MainForm : Form
    {
        //String[] filenames, filepaths;
        //public static string MAINFORM = "MAINFORM";
//         public string NAME
//         {
//             get { return MAINFORM; }
//             set { MAINFORM = value; }
//         }
        
        public MainForm()
        {
            InitializeComponent();                        
        }

        private void PhanQuyenHeThong()
        {
            QuanLyQuyenHan roles = LoginController.GetInstance().GetRoles();
            main_menu.Enabled = roles.GetUserRight(main_menu.Name);

            foreach (ToolStripMenuItem i in main_menu.Items)
            {
                i.Enabled = roles.GetUserRight(i.Name);
                foreach (ToolStripItem j in i.DropDownItems)
                {
                    j.Enabled = roles.GetUserRight(j.Name);
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            main_menu.Enabled = false;

            //             FormManager.CurrentSanBay = null;
            //             FormManager.CurrentTuyenBay = null;
            //             FormManager.CurrentQuyDinh = null;
            //             FormManager.CurrentLichChuyenBay = null;
            //             FormManager.CurrentLichBay = null;
            //             FormManager.CurrentLayVe = null;
            //             FormManager.CurrentHangVe = null;
            //             
            //             FormManager.CurrentDatCho = null;
            //             FormManager.CurrentBaoCaoThang = null;
            //             FormManager.CurrentBaoCaoNam = null;
            // login;
            //             Login l = new Login();
            //             l.ShowDialog();
            //             if (l.IsLogged)
            //             {
            //                 PhanQuyenHeThong();
            //             }
        }

        #region Menu Chính

        #region Menu Thêm

        // thêm sân bay
        private void sanBayToolStripMenuItemTiepNhan_Click(object sender, EventArgs e)
        {
            //             FormManager.CurrentSanBay.MdiParent = this;
            //             FormManager.CurrentSanBay.Show();
            //             FormManager.CurrentSanBay.Focus();
            //             FormManager.CurrentSanBay.BeCalledByForm = NAME;
            SanBay s = new SanBay();
            s.ShowDialog();
        }

        // thêm Tuyến Bay
        private void tuyenBayToolStripMenuItemTiepNhan_Click(object sender, EventArgs e)
        {
            //             FormManager.CurrentTuyenBay.MdiParent = this;
            //             FormManager.CurrentTuyenBay.Show();
            //             FormManager.CurrentTuyenBay.Focus();
            //             FormManager.CurrentTuyenBay.BeCalledByForm = NAME;
            TuyenBay t = new TuyenBay();
            t.ShowDialog();
        }

        // thêm Lịch Chuyến Bay
        private void lichChuyenBayToolStripMenuItemTiepNhan_Click(object sender, EventArgs e)
        {
            //             FormManager.CurrentLichChuyenBay.MdiParent = this;
            //             FormManager.CurrentLichChuyenBay.Show();
            // 
            //             FormManager.CurrentLichChuyenBay.BeCalledByForm = NAME;
            ThemLichChuyenBay l = new ThemLichChuyenBay();
            l.ShowDialog();
        }

        // thêm Hạng vé
        private void hạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //             FormManager.CurrentHangVe.MdiParent = this;
            //             FormManager.CurrentHangVe.Show();
            //             FormManager.CurrentHangVe.BeCalledByForm = NAME;
            HangVe h = new HangVe();
            h.ShowDialog();

        }
        #endregion

        #region Menu Kinh Doanh
        // bán vé
        private void banVeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //             FormManager.CurrentLayVe.MdiParent = this;
            //             FormManager.CurrentLayVe.Show();
            //FormManager.CurrentLayVe.BeCalledByForm = NAME;
            LayVe l = new LayVe();
            l.ShowDialog();
        }

        // đặt chỗ
        private void datChoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //             FormManager.CurrentDatCho.MdiParent = this;
            //             FormManager.CurrentDatCho.Show();
            //FormManager.CurrentDatCho.BeCalledByForm = NAME;
            DatCho d = new DatCho();
            d.ShowDialog();

        }

        #endregion

        #region Menu Tra Cứu

        // tra cứu lịch chuyến bay
        private void lichChuyếnBayToolStripMenuItemTraCuu_Click(object sender, EventArgs e)
        {
            //             FormManager.CurrentLichBay.MdiParent = this;
            //             FormManager.CurrentLichBay.Show();
            //             FormManager.CurrentLichBay.Focus();
            //             FormManager.CurrentLichBay.BeCalledByForm = NAME;
            TraCuuLichBay l = new TraCuuLichBay();
            l.ShowDialog();

        }
        #endregion

        #region Menu Báo Cáo
        // doanh thu tháng
        private void doanhThuThangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormManager.CurrentBaoCaoThang.MdiParent = this;
            //FormManager.CurrentBaoCaoThang.Show();
            //FormManager.CurrentBaoCaoThang.Focus();
            //FormManager.CurrentBaoCaoThang.BeCalledByForm = NAME;
            BaoCaoNam b = new BaoCaoNam();
            b.ShowDialog();
        }

        // doanh thu năm
        private void doanhThuNamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //             FormManager.CurrentBaoCaoNam.MdiParent = this;
            //             FormManager.CurrentBaoCaoNam.Show();
            //             FormManager.CurrentBaoCaoNam.Focus();
            //             FormManager.CurrentBaoCaoNam.BeCalledByForm = NAME;
            BaoCaoThang b = new BaoCaoThang();
            b.ShowDialog();
        }


        #endregion

        #region Quy Định
        // danh sách quy định
        private void danhSachQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuyDinh qd = new QuyDinh();
            qd.ShowDialog();
        }

        #endregion

        #region Menu Giới thiệu
        private void veChuongTrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #endregion

        // thoát chương trình
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //khong can thiet phai thong bao o day

            /* if (e.CloseReason == CloseReason.WindowsShutDown) return;

             if (e.CloseReason == CloseReason.UserClosing)
             {
                 switch (MessageBox.Show(this, "Bạn có muốn thoát khỏi chương trình hoàn toàn không?", "Thông báo!",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                 {

                     case DialogResult.Yes:
                         e.Cancel = false;
                         break;
                     case DialogResult.No:
                         e.Cancel = true;
                         break;
                 }
             }
             */
        }

        private void dữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormManager.CurrentDataView.MdiParent = this;
            //FormManager.CurrentDataView.Show();
            //FormManager.CurrentDataView.BeCalledByForm = NAME;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

//         private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
//         {
//             Login l = new Login();
//             l.ShowDialog();
//             if (l.IsLogged)
//             {
//                 PhanQuyenHeThong();
//             }
//         }

        private void menu_Dangxuat_Click(object sender, EventArgs e)
        {
            main_menu.Enabled = false;
            LoginController.Destroy();
            lb_gioithieu.Location = new Point(343, 60);
            lb_ma.Visible = true;
            lb_pass.Visible = true;
            lb_notify.Visible = true;
            txt_password.Visible = true;
            txt_username.Visible = true;
            btn_Close.Visible = true;
            btn_Login.Visible = true;
            
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhanQuyen p = new PhanQuyen();
            p.ShowDialog();
        }

        private void menu_Themnguoidung_Click(object sender, EventArgs e)
        {
            ThemNguoiDung tnd = new ThemNguoiDung();
            tnd.ShowDialog();
        }

        private void kinhDoanh_traVe_Click(object sender, EventArgs e)
        {
            TraVe t = new TraVe();
            t.ShowDialog();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btn_Login_Click(object sender, EventArgs e)
        {
            HeThongBLL bll = new HeThongBLL();
            if (txt_username.Text == "")
            {
                lb_notify.Text = "* Bạn chưa nhập tên đăng nhập!";
                return;
            }
            if (txt_password.Text == "")
            {
                lb_notify.Text = "* Bạn chưa nhập mật khẩu!";
                return;
            }
            if (bll.CheckLogin(txt_username.Text, txt_password.Text))
            {
                LoginController.GetInstance().SetLogin(txt_username.Text);
                PhanQuyenHeThong();
                lb_ma.Visible = false;
                lb_pass.Visible = false;
                lb_notify.Visible = false;
                txt_password.Visible = false;
                txt_username.Visible = false;
                btn_Close.Visible = false;
                btn_Login.Visible = false;                
            }
            else
            {
                lb_notify.Text = "* Tên truy cập hoặc mật khẩu không đúng!";
            }
        }




        //         private void btnOpen_Click(object sender, EventArgs e)
        //         {
        //             if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //             {
        //                 filenames = openFileDialog1.SafeFileNames;
        //                 filepaths = openFileDialog1.FileNames;
        //                 foreach (String filename in filenames)
        //                 {
        //                     listBox.Items.Add(filename);
        //                 }
        //             }
        //         }
        // 
        //         private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //         {
        //             axWindowsMediaPlayer1.URL = filepaths[listBox.SelectedIndex];
        //         }

    }
}

