namespace MainForm
{
    partial class TraCuuLichBay
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
            this.groupBoxThongTinTraCuu = new System.Windows.Forms.GroupBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonXuatTapTin = new System.Windows.Forms.Button();
            this.buttonQuayVe = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewKQ = new System.Windows.Forms.DataGridView();
            this.ColumnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSanBayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSanBayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnThoiGianBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoGheTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoGheDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxThongTinTraCuu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKQ)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxThongTinTraCuu
            // 
            this.groupBoxThongTinTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThongTinTraCuu.Controls.Add(this.btn_tim);
            this.groupBoxThongTinTraCuu.Controls.Add(this.textBox1);
            this.groupBoxThongTinTraCuu.Controls.Add(this.label9);
            this.groupBoxThongTinTraCuu.Location = new System.Drawing.Point(14, 43);
            this.groupBoxThongTinTraCuu.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxThongTinTraCuu.Name = "groupBoxThongTinTraCuu";
            this.groupBoxThongTinTraCuu.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxThongTinTraCuu.Size = new System.Drawing.Size(839, 168);
            this.groupBoxThongTinTraCuu.TabIndex = 0;
            this.groupBoxThongTinTraCuu.TabStop = false;
            this.groupBoxThongTinTraCuu.Text = "Nhập Thông Tin Cần Tìm";
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(422, 34);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 24);
            this.btn_tim.TabIndex = 14;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 26);
            this.textBox1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mã Chuyến bay";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonXuatTapTin);
            this.groupBox1.Controls.Add(this.buttonQuayVe);
            this.groupBox1.Location = new System.Drawing.Point(863, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(143, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // buttonXuatTapTin
            // 
            this.buttonXuatTapTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXuatTapTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonXuatTapTin.Location = new System.Drawing.Point(10, 29);
            this.buttonXuatTapTin.Margin = new System.Windows.Forms.Padding(5);
            this.buttonXuatTapTin.Name = "buttonXuatTapTin";
            this.buttonXuatTapTin.Size = new System.Drawing.Size(123, 37);
            this.buttonXuatTapTin.TabIndex = 9;
            this.buttonXuatTapTin.Text = "Xuất ra tập tin";
            this.buttonXuatTapTin.UseVisualStyleBackColor = true;
            // 
            // buttonQuayVe
            // 
            this.buttonQuayVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuayVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuayVe.Location = new System.Drawing.Point(10, 77);
            this.buttonQuayVe.Margin = new System.Windows.Forms.Padding(5);
            this.buttonQuayVe.Name = "buttonQuayVe";
            this.buttonQuayVe.Size = new System.Drawing.Size(123, 37);
            this.buttonQuayVe.TabIndex = 3;
            this.buttonQuayVe.TabStop = false;
            this.buttonQuayVe.Text = "Quay về";
            this.buttonQuayVe.UseVisualStyleBackColor = true;
            this.buttonQuayVe.Click += new System.EventHandler(this.buttonQuayVe_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridViewKQ);
            this.groupBox3.Location = new System.Drawing.Point(14, 235);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(872, 358);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết Quả Tra Cứu";
            // 
            // dataGridViewKQ
            // 
            this.dataGridViewKQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSTT,
            this.ColumnMaChuyenBay,
            this.ColumnSanBayDi,
            this.ColumnSanBayDen,
            this.ColumnKhoiHanh,
            this.Column1,
            this.ColumnThoiGianBay,
            this.ColumnSoGheTrong,
            this.ColumnSoGheDat});
            this.dataGridViewKQ.Location = new System.Drawing.Point(10, 29);
            this.dataGridViewKQ.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewKQ.Name = "dataGridViewKQ";
            this.dataGridViewKQ.Size = new System.Drawing.Size(852, 319);
            this.dataGridViewKQ.TabIndex = 0;
            this.dataGridViewKQ.TabStop = false;
            // 
            // ColumnSTT
            // 
            this.ColumnSTT.FillWeight = 70F;
            this.ColumnSTT.HeaderText = "STT";
            this.ColumnSTT.Name = "ColumnSTT";
            this.ColumnSTT.ReadOnly = true;
            this.ColumnSTT.Width = 70;
            // 
            // ColumnMaChuyenBay
            // 
            this.ColumnMaChuyenBay.DataPropertyName = "MaChuyenBay";
            this.ColumnMaChuyenBay.FillWeight = 70F;
            this.ColumnMaChuyenBay.HeaderText = "Mã Chuyến Bay";
            this.ColumnMaChuyenBay.Name = "ColumnMaChuyenBay";
            this.ColumnMaChuyenBay.ReadOnly = true;
            this.ColumnMaChuyenBay.Width = 108;
            // 
            // ColumnSanBayDi
            // 
            this.ColumnSanBayDi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSanBayDi.DataPropertyName = "TenSanBayDi";
            this.ColumnSanBayDi.HeaderText = "Sân Bay Đi";
            this.ColumnSanBayDi.Name = "ColumnSanBayDi";
            this.ColumnSanBayDi.ReadOnly = true;
            // 
            // ColumnSanBayDen
            // 
            this.ColumnSanBayDen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSanBayDen.DataPropertyName = "TenSanBayDen";
            this.ColumnSanBayDen.HeaderText = "Sân Bay Đến";
            this.ColumnSanBayDen.Name = "ColumnSanBayDen";
            this.ColumnSanBayDen.ReadOnly = true;
            // 
            // ColumnKhoiHanh
            // 
            this.ColumnKhoiHanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnKhoiHanh.DataPropertyName = "NgayKhoiHanh";
            this.ColumnKhoiHanh.HeaderText = "Ngày Khởi Hành";
            this.ColumnKhoiHanh.Name = "ColumnKhoiHanh";
            this.ColumnKhoiHanh.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "GioKhoiHanh";
            this.Column1.HeaderText = "Giờ Khởi Hành";
            this.Column1.Name = "Column1";
            // 
            // ColumnThoiGianBay
            // 
            this.ColumnThoiGianBay.DataPropertyName = "ThoiGianBay";
            this.ColumnThoiGianBay.HeaderText = "Thời Gian Bay";
            this.ColumnThoiGianBay.Name = "ColumnThoiGianBay";
            this.ColumnThoiGianBay.ReadOnly = true;
            this.ColumnThoiGianBay.Width = 70;
            // 
            // ColumnSoGheTrong
            // 
            this.ColumnSoGheTrong.DataPropertyName = "TongSoGheTrong";
            this.ColumnSoGheTrong.FillWeight = 70F;
            this.ColumnSoGheTrong.HeaderText = "Số Ghế Trống";
            this.ColumnSoGheTrong.Name = "ColumnSoGheTrong";
            this.ColumnSoGheTrong.ReadOnly = true;
            this.ColumnSoGheTrong.Width = 70;
            // 
            // ColumnSoGheDat
            // 
            this.ColumnSoGheDat.DataPropertyName = "TongSoGheDat";
            this.ColumnSoGheDat.FillWeight = 70F;
            this.ColumnSoGheDat.HeaderText = "Số Ghế Đặt";
            this.ColumnSoGheDat.Name = "ColumnSoGheDat";
            this.ColumnSoGheDat.ReadOnly = true;
            this.ColumnSoGheDat.Width = 70;
            // 
            // TraCuuLichBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 599);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxThongTinTraCuu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1022, 638);
            this.Name = "TraCuuLichBay";
            this.Text = "Tra Cứu Chuyến Bay";
            this.Load += new System.EventHandler(this.LichBay_Load);
            this.groupBoxThongTinTraCuu.ResumeLayout(false);
            this.groupBoxThongTinTraCuu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinTraCuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonQuayVe;
        private System.Windows.Forms.Button buttonXuatTapTin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSanBayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnThoiGianBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoGheTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoGheDat;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox textBox1;
    }
}