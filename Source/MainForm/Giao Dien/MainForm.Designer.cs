namespace MainForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.menu_Them = new System.Windows.Forms.ToolStripMenuItem();
            this.them_Hangve = new System.Windows.Forms.ToolStripMenuItem();
            this.them_Sanbay = new System.Windows.Forms.ToolStripMenuItem();
            this.them_Tuyenbay = new System.Windows.Forms.ToolStripMenuItem();
            this.them_Lichchuyenbay = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Kinhdoanh = new System.Windows.Forms.ToolStripMenuItem();
            this.kinhdoanh_BanVe = new System.Windows.Forms.ToolStripMenuItem();
            this.kinhdoanh_Datcho = new System.Windows.Forms.ToolStripMenuItem();
            this.kinhDoanh_traVe = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Tracuu = new System.Windows.Forms.ToolStripMenuItem();
            this.tracuu_Lichbay = new System.Windows.Forms.ToolStripMenuItem();
            this.tracuu_Dulieu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.baocao_Thang = new System.Windows.Forms.ToolStripMenuItem();
            this.baocao_Nam = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Quydinh = new System.Windows.Forms.ToolStripMenuItem();
            this.quydinh_Danhsach = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Themnguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Phanquyen = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_gioithieu = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lb_ma = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lb_notify = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.main_menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.BackColor = System.Drawing.Color.White;
            this.main_menu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Them,
            this.menu_Kinhdoanh,
            this.menu_Tracuu,
            this.menu_Baocao,
            this.menu_Quydinh,
            this.menu_Hethong});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(1020, 25);
            this.main_menu.TabIndex = 21;
            // 
            // menu_Them
            // 
            this.menu_Them.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.them_Hangve,
            this.them_Sanbay,
            this.them_Tuyenbay,
            this.them_Lichchuyenbay});
            this.menu_Them.ForeColor = System.Drawing.Color.Blue;
            this.menu_Them.Name = "menu_Them";
            this.menu_Them.Size = new System.Drawing.Size(54, 21);
            this.menu_Them.Text = "Thêm";
            // 
            // them_Hangve
            // 
            this.them_Hangve.ForeColor = System.Drawing.Color.Blue;
            this.them_Hangve.Name = "them_Hangve";
            this.them_Hangve.Size = new System.Drawing.Size(182, 22);
            this.them_Hangve.Text = "Hạng Vé";
            this.them_Hangve.Click += new System.EventHandler(this.hạngVéToolStripMenuItem_Click);
            // 
            // them_Sanbay
            // 
            this.them_Sanbay.ForeColor = System.Drawing.Color.Blue;
            this.them_Sanbay.Name = "them_Sanbay";
            this.them_Sanbay.Size = new System.Drawing.Size(182, 22);
            this.them_Sanbay.Text = "Sân Bay";
            this.them_Sanbay.Click += new System.EventHandler(this.sanBayToolStripMenuItemTiepNhan_Click);
            // 
            // them_Tuyenbay
            // 
            this.them_Tuyenbay.ForeColor = System.Drawing.Color.Blue;
            this.them_Tuyenbay.Name = "them_Tuyenbay";
            this.them_Tuyenbay.Size = new System.Drawing.Size(182, 22);
            this.them_Tuyenbay.Text = "Tuyến Bay";
            this.them_Tuyenbay.Click += new System.EventHandler(this.tuyenBayToolStripMenuItemTiepNhan_Click);
            // 
            // them_Lichchuyenbay
            // 
            this.them_Lichchuyenbay.ForeColor = System.Drawing.Color.Blue;
            this.them_Lichchuyenbay.Name = "them_Lichchuyenbay";
            this.them_Lichchuyenbay.Size = new System.Drawing.Size(182, 22);
            this.them_Lichchuyenbay.Text = "Lịch Chuyến Bay";
            this.them_Lichchuyenbay.Click += new System.EventHandler(this.lichChuyenBayToolStripMenuItemTiepNhan_Click);
            // 
            // menu_Kinhdoanh
            // 
            this.menu_Kinhdoanh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kinhdoanh_BanVe,
            this.kinhdoanh_Datcho,
            this.kinhDoanh_traVe});
            this.menu_Kinhdoanh.ForeColor = System.Drawing.Color.Blue;
            this.menu_Kinhdoanh.Name = "menu_Kinhdoanh";
            this.menu_Kinhdoanh.Size = new System.Drawing.Size(94, 21);
            this.menu_Kinhdoanh.Text = "Kinh Doanh";
            // 
            // kinhdoanh_BanVe
            // 
            this.kinhdoanh_BanVe.ForeColor = System.Drawing.Color.Blue;
            this.kinhdoanh_BanVe.Name = "kinhdoanh_BanVe";
            this.kinhdoanh_BanVe.Size = new System.Drawing.Size(127, 22);
            this.kinhdoanh_BanVe.Text = "Bán Vé";
            this.kinhdoanh_BanVe.Click += new System.EventHandler(this.banVeToolStripMenuItem_Click);
            // 
            // kinhdoanh_Datcho
            // 
            this.kinhdoanh_Datcho.ForeColor = System.Drawing.Color.Blue;
            this.kinhdoanh_Datcho.Name = "kinhdoanh_Datcho";
            this.kinhdoanh_Datcho.Size = new System.Drawing.Size(127, 22);
            this.kinhdoanh_Datcho.Text = "Đặt Chỗ";
            this.kinhdoanh_Datcho.Click += new System.EventHandler(this.datChoToolStripMenuItem_Click);
            // 
            // kinhDoanh_traVe
            // 
            this.kinhDoanh_traVe.ForeColor = System.Drawing.Color.Blue;
            this.kinhDoanh_traVe.Name = "kinhDoanh_traVe";
            this.kinhDoanh_traVe.Size = new System.Drawing.Size(127, 22);
            this.kinhDoanh_traVe.Text = "Trả Vé";
            this.kinhDoanh_traVe.Click += new System.EventHandler(this.kinhDoanh_traVe_Click);
            // 
            // menu_Tracuu
            // 
            this.menu_Tracuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tracuu_Lichbay,
            this.tracuu_Dulieu});
            this.menu_Tracuu.ForeColor = System.Drawing.Color.Blue;
            this.menu_Tracuu.Name = "menu_Tracuu";
            this.menu_Tracuu.Size = new System.Drawing.Size(70, 21);
            this.menu_Tracuu.Text = "Tra Cứu";
            // 
            // tracuu_Lichbay
            // 
            this.tracuu_Lichbay.ForeColor = System.Drawing.Color.Blue;
            this.tracuu_Lichbay.Name = "tracuu_Lichbay";
            this.tracuu_Lichbay.Size = new System.Drawing.Size(182, 22);
            this.tracuu_Lichbay.Text = "Lịch Chuyến Bay";
            this.tracuu_Lichbay.Click += new System.EventHandler(this.lichChuyếnBayToolStripMenuItemTraCuu_Click);
            // 
            // tracuu_Dulieu
            // 
            this.tracuu_Dulieu.ForeColor = System.Drawing.Color.Blue;
            this.tracuu_Dulieu.Name = "tracuu_Dulieu";
            this.tracuu_Dulieu.Size = new System.Drawing.Size(182, 22);
            this.tracuu_Dulieu.Text = "Dữ Liệu";
            this.tracuu_Dulieu.Click += new System.EventHandler(this.dữLiệuToolStripMenuItem_Click);
            // 
            // menu_Baocao
            // 
            this.menu_Baocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baocao_Thang,
            this.baocao_Nam});
            this.menu_Baocao.ForeColor = System.Drawing.Color.Blue;
            this.menu_Baocao.Name = "menu_Baocao";
            this.menu_Baocao.Size = new System.Drawing.Size(71, 21);
            this.menu_Baocao.Text = "Báo Cáo";
            // 
            // baocao_Thang
            // 
            this.baocao_Thang.ForeColor = System.Drawing.Color.Blue;
            this.baocao_Thang.Name = "baocao_Thang";
            this.baocao_Thang.Size = new System.Drawing.Size(186, 22);
            this.baocao_Thang.Text = "Doanh Thu Năm";
            this.baocao_Thang.Click += new System.EventHandler(this.doanhThuThangToolStripMenuItem_Click);
            // 
            // baocao_Nam
            // 
            this.baocao_Nam.ForeColor = System.Drawing.Color.Blue;
            this.baocao_Nam.Name = "baocao_Nam";
            this.baocao_Nam.Size = new System.Drawing.Size(186, 22);
            this.baocao_Nam.Text = "Doanh Thu Tháng";
            this.baocao_Nam.Click += new System.EventHandler(this.doanhThuNamToolStripMenuItem_Click);
            // 
            // menu_Quydinh
            // 
            this.menu_Quydinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quydinh_Danhsach});
            this.menu_Quydinh.ForeColor = System.Drawing.Color.Blue;
            this.menu_Quydinh.Name = "menu_Quydinh";
            this.menu_Quydinh.Size = new System.Drawing.Size(80, 21);
            this.menu_Quydinh.Text = "Quy Định";
            // 
            // quydinh_Danhsach
            // 
            this.quydinh_Danhsach.ForeColor = System.Drawing.Color.Blue;
            this.quydinh_Danhsach.Name = "quydinh_Danhsach";
            this.quydinh_Danhsach.Size = new System.Drawing.Size(146, 22);
            this.quydinh_Danhsach.Text = "Danh Sách ";
            this.quydinh_Danhsach.Click += new System.EventHandler(this.danhSachQuyĐịnhToolStripMenuItem_Click);
            // 
            // menu_Hethong
            // 
            this.menu_Hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Dangxuat,
            this.menu_Themnguoidung,
            this.menu_Phanquyen});
            this.menu_Hethong.ForeColor = System.Drawing.Color.Blue;
            this.menu_Hethong.Name = "menu_Hethong";
            this.menu_Hethong.Size = new System.Drawing.Size(76, 21);
            this.menu_Hethong.Text = "Hệ thống";
            this.menu_Hethong.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menu_Dangxuat
            // 
            this.menu_Dangxuat.ForeColor = System.Drawing.Color.Blue;
            this.menu_Dangxuat.Name = "menu_Dangxuat";
            this.menu_Dangxuat.Size = new System.Drawing.Size(183, 22);
            this.menu_Dangxuat.Text = "Đăng xuất";
            this.menu_Dangxuat.Click += new System.EventHandler(this.menu_Dangxuat_Click);
            // 
            // menu_Themnguoidung
            // 
            this.menu_Themnguoidung.ForeColor = System.Drawing.Color.Blue;
            this.menu_Themnguoidung.Name = "menu_Themnguoidung";
            this.menu_Themnguoidung.Size = new System.Drawing.Size(183, 22);
            this.menu_Themnguoidung.Text = "Thêm người dùng";
            this.menu_Themnguoidung.Click += new System.EventHandler(this.menu_Themnguoidung_Click);
            // 
            // menu_Phanquyen
            // 
            this.menu_Phanquyen.ForeColor = System.Drawing.Color.Blue;
            this.menu_Phanquyen.Name = "menu_Phanquyen";
            this.menu_Phanquyen.Size = new System.Drawing.Size(183, 22);
            this.menu_Phanquyen.Text = "Phân quyền";
            this.menu_Phanquyen.Click += new System.EventHandler(this.phânQuyềnToolStripMenuItem_Click);
            // 
            // lb_gioithieu
            // 
            this.lb_gioithieu.AutoSize = true;
            this.lb_gioithieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gioithieu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_gioithieu.Location = new System.Drawing.Point(153, 56);
            this.lb_gioithieu.Name = "lb_gioithieu";
            this.lb_gioithieu.Size = new System.Drawing.Size(693, 46);
            this.lb_gioithieu.TabIndex = 22;
            this.lb_gioithieu.Text = "PHẦN MỀM QUẢN LÝ CHUYẾN BAY";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(185, 152);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 35);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Thoát";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(43, 152);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(112, 35);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lb_ma
            // 
            this.lb_ma.AutoSize = true;
            this.lb_ma.Location = new System.Drawing.Point(22, 34);
            this.lb_ma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ma.Name = "lb_ma";
            this.lb_ma.Size = new System.Drawing.Size(113, 20);
            this.lb_ma.TabIndex = 26;
            this.lb_ma.Text = "Mã Nhân Viên:";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(22, 85);
            this.lb_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(79, 20);
            this.lb_pass.TabIndex = 25;
            this.lb_pass.Text = "Mật khẩu:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(163, 34);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(208, 26);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "NV0001";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(163, 79);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '#';
            this.txt_password.Size = new System.Drawing.Size(208, 26);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "luanft";
            // 
            // lb_notify
            // 
            this.lb_notify.AutoSize = true;
            this.lb_notify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_notify.ForeColor = System.Drawing.Color.Red;
            this.lb_notify.Location = new System.Drawing.Point(254, 343);
            this.lb_notify.Name = "lb_notify";
            this.lb_notify.Size = new System.Drawing.Size(0, 20);
            this.lb_notify.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Close);
            this.groupBox1.Controls.Add(this.btn_Login);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.lb_ma);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.lb_pass);
            this.groupBox1.Location = new System.Drawing.Point(258, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 207);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1020, 727);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_notify);
            this.Controls.Add(this.lb_gioithieu);
            this.Controls.Add(this.main_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(477, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Chuyến Bay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem menu_Them;
        private System.Windows.Forms.ToolStripMenuItem them_Sanbay;
        private System.Windows.Forms.ToolStripMenuItem them_Tuyenbay;
        private System.Windows.Forms.ToolStripMenuItem them_Lichchuyenbay;
        private System.Windows.Forms.ToolStripMenuItem menu_Kinhdoanh;
        private System.Windows.Forms.ToolStripMenuItem kinhdoanh_BanVe;
        private System.Windows.Forms.ToolStripMenuItem kinhdoanh_Datcho;
        private System.Windows.Forms.ToolStripMenuItem menu_Tracuu;
        private System.Windows.Forms.ToolStripMenuItem tracuu_Lichbay;
        private System.Windows.Forms.ToolStripMenuItem menu_Baocao;
        private System.Windows.Forms.ToolStripMenuItem baocao_Thang;
        private System.Windows.Forms.ToolStripMenuItem baocao_Nam;
        private System.Windows.Forms.ToolStripMenuItem menu_Quydinh;
        private System.Windows.Forms.ToolStripMenuItem quydinh_Danhsach;
        private System.Windows.Forms.ToolStripMenuItem them_Hangve;
        private System.Windows.Forms.ToolStripMenuItem tracuu_Dulieu;
        private System.Windows.Forms.ToolStripMenuItem menu_Hethong;
        private System.Windows.Forms.ToolStripMenuItem menu_Dangxuat;
        private System.Windows.Forms.ToolStripMenuItem menu_Themnguoidung;
        private System.Windows.Forms.ToolStripMenuItem menu_Phanquyen;
        private System.Windows.Forms.ToolStripMenuItem kinhDoanh_traVe;
        private System.Windows.Forms.Label lb_gioithieu;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lb_ma;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lb_notify;
        private System.Windows.Forms.GroupBox groupBox1;



    }
}

