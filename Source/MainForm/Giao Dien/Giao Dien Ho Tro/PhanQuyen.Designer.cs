namespace MainForm.Giao_Dien.Giao_Dien_Ho_Tro
{
    partial class PhanQuyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_nhomNguoiDung = new System.Windows.Forms.ComboBox();
            this.dt_danhSachQuyen = new System.Windows.Forms.DataGridView();
            this.MaChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuDung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dt_quyenNguoiDung = new System.Windows.Forms.DataGridView();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.txt_maNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SU_DUNG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaNhomNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhomNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt_danhSachQuyen)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_quyenNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm người dùng:";
            // 
            // cb_nhomNguoiDung
            // 
            this.cb_nhomNguoiDung.FormattingEnabled = true;
            this.cb_nhomNguoiDung.Location = new System.Drawing.Point(115, 6);
            this.cb_nhomNguoiDung.Name = "cb_nhomNguoiDung";
            this.cb_nhomNguoiDung.Size = new System.Drawing.Size(195, 21);
            this.cb_nhomNguoiDung.TabIndex = 1;
            this.cb_nhomNguoiDung.SelectedIndexChanged += new System.EventHandler(this.cb_nhomNguoiDung_SelectedIndexChanged);
            // 
            // dt_danhSachQuyen
            // 
            this.dt_danhSachQuyen.AllowUserToAddRows = false;
            this.dt_danhSachQuyen.AllowUserToDeleteRows = false;
            this.dt_danhSachQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_danhSachQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChucNang,
            this.SuDung,
            this.ChucNang});
            this.dt_danhSachQuyen.Location = new System.Drawing.Point(18, 61);
            this.dt_danhSachQuyen.Name = "dt_danhSachQuyen";
            this.dt_danhSachQuyen.Size = new System.Drawing.Size(472, 263);
            this.dt_danhSachQuyen.TabIndex = 2;
            // 
            // MaChucNang
            // 
            this.MaChucNang.DataPropertyName = "MaChucNang";
            this.MaChucNang.FillWeight = 150F;
            this.MaChucNang.HeaderText = "Mã Chức Năng";
            this.MaChucNang.Name = "MaChucNang";
            this.MaChucNang.Visible = false;
            this.MaChucNang.Width = 200;
            // 
            // SuDung
            // 
            this.SuDung.DataPropertyName = "UserRole";
            this.SuDung.HeaderText = "Sử dụng";
            this.SuDung.Name = "SuDung";
            this.SuDung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SuDung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ChucNang
            // 
            this.ChucNang.DataPropertyName = "MoTaChucNang";
            this.ChucNang.HeaderText = "Chức Năng";
            this.ChucNang.Name = "ChucNang";
            this.ChucNang.Width = 300;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách quyền:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 367);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dt_danhSachQuyen);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cb_nhomNguoiDung);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(563, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phân theo nhóm người dùng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dt_quyenNguoiDung);
            this.tabPage2.Controls.Add(this.btn_capNhat);
            this.tabPage2.Controls.Add(this.btn_timKiem);
            this.tabPage2.Controls.Add(this.txt_maNhanVien);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(563, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phân cho người sử dụng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dt_quyenNguoiDung
            // 
            this.dt_quyenNguoiDung.AllowUserToAddRows = false;
            this.dt_quyenNguoiDung.AllowUserToDeleteRows = false;
            this.dt_quyenNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_quyenNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SU_DUNG,
            this.MaNhomNguoiDung,
            this.TenNhomNguoiDung});
            this.dt_quyenNguoiDung.Location = new System.Drawing.Point(63, 115);
            this.dt_quyenNguoiDung.Name = "dt_quyenNguoiDung";
            this.dt_quyenNguoiDung.Size = new System.Drawing.Size(443, 174);
            this.dt_quyenNguoiDung.TabIndex = 3;
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Location = new System.Drawing.Point(394, 295);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(75, 23);
            this.btn_capNhat.TabIndex = 2;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Location = new System.Drawing.Point(356, 35);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timKiem.TabIndex = 2;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // txt_maNhanVien
            // 
            this.txt_maNhanVien.Location = new System.Drawing.Point(166, 35);
            this.txt_maNhanVien.Name = "txt_maNhanVien";
            this.txt_maNhanVien.Size = new System.Drawing.Size(160, 20);
            this.txt_maNhanVien.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bảng quyền hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập mã nhân viên";
            // 
            // SU_DUNG
            // 
            this.SU_DUNG.DataPropertyName = "HAVE";
            this.SU_DUNG.HeaderText = "Thuộc nhóm";
            this.SU_DUNG.Name = "SU_DUNG";
            // 
            // MaNhomNguoiDung
            // 
            this.MaNhomNguoiDung.DataPropertyName = "MaNhomNguoiDung";
            this.MaNhomNguoiDung.HeaderText = "Mã nhóm";
            this.MaNhomNguoiDung.Name = "MaNhomNguoiDung";
            this.MaNhomNguoiDung.ReadOnly = true;
            this.MaNhomNguoiDung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNhomNguoiDung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenNhomNguoiDung
            // 
            this.TenNhomNguoiDung.DataPropertyName = "TenNhomNguoiDung";
            this.TenNhomNguoiDung.HeaderText = "Nhóm Người Dùng";
            this.TenNhomNguoiDung.Name = "TenNhomNguoiDung";
            this.TenNhomNguoiDung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenNhomNguoiDung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenNhomNguoiDung.Width = 200;
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 383);
            this.Controls.Add(this.tabControl1);
            this.Name = "PhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhanQuyen";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_danhSachQuyen)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_quyenNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_nhomNguoiDung;
        private System.Windows.Forms.DataGridView dt_danhSachQuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucNang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucNang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.TextBox txt_maNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.DataGridView dt_quyenNguoiDung;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SU_DUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhomNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhomNguoiDung;
    }
}