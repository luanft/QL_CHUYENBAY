namespace MainForm.Giao_Dien.Giao_Dien_Ho_Tro
{
    partial class ThemNguoiDung
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
            this.txt_maNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_chucVu = new System.Windows.Forms.ComboBox();
            this.btn_themNhanVien = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_thongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // txt_maNhanVien
            // 
            this.txt_maNhanVien.Location = new System.Drawing.Point(109, 39);
            this.txt_maNhanVien.Name = "txt_maNhanVien";
            this.txt_maNhanVien.ReadOnly = true;
            this.txt_maNhanVien.Size = new System.Drawing.Size(157, 20);
            this.txt_maNhanVien.TabIndex = 0;
            this.txt_maNhanVien.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(109, 98);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(157, 20);
            this.txt_hoTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(109, 124);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(157, 20);
            this.txt_email.TabIndex = 2;
            this.txt_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chức vụ";
            // 
            // cb_chucVu
            // 
            this.cb_chucVu.FormattingEnabled = true;
            this.cb_chucVu.Location = new System.Drawing.Point(109, 67);
            this.cb_chucVu.Name = "cb_chucVu";
            this.cb_chucVu.Size = new System.Drawing.Size(157, 21);
            this.cb_chucVu.TabIndex = 0;
            // 
            // btn_themNhanVien
            // 
            this.btn_themNhanVien.Location = new System.Drawing.Point(70, 199);
            this.btn_themNhanVien.Name = "btn_themNhanVien";
            this.btn_themNhanVien.Size = new System.Drawing.Size(106, 23);
            this.btn_themNhanVien.TabIndex = 3;
            this.btn_themNhanVien.Text = "Thêm nhân viên";
            this.btn_themNhanVien.UseVisualStyleBackColor = true;
            this.btn_themNhanVien.Click += new System.EventHandler(this.btn_themNhanVien_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(191, 199);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_thongBao
            // 
            this.lb_thongBao.AutoSize = true;
            this.lb_thongBao.BackColor = System.Drawing.SystemColors.Control;
            this.lb_thongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongBao.ForeColor = System.Drawing.Color.Red;
            this.lb_thongBao.Location = new System.Drawing.Point(29, 169);
            this.lb_thongBao.Name = "lb_thongBao";
            this.lb_thongBao.Size = new System.Drawing.Size(0, 13);
            this.lb_thongBao.TabIndex = 0;
            // 
            // ThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 259);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_themNhanVien);
            this.Controls.Add(this.cb_chucVu);
            this.Controls.Add(this.lb_thongBao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "ThemNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNguoiDung";
            this.Load += new System.EventHandler(this.ThemNguoiDung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_chucVu;
        private System.Windows.Forms.Button btn_themNhanVien;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_thongBao;
    }
}