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
            this.comboBoxMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDau = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerCuoi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSanBayDen = new System.Windows.Forms.ComboBox();
            this.comboBoxSanBayDi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKQ)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxThongTinTraCuu
            // 
            this.groupBoxThongTinTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThongTinTraCuu.Controls.Add(this.comboBoxMaChuyenBay);
            this.groupBoxThongTinTraCuu.Controls.Add(this.label9);
            this.groupBoxThongTinTraCuu.Controls.Add(this.groupBox2);
            this.groupBoxThongTinTraCuu.Controls.Add(this.comboBoxSanBayDen);
            this.groupBoxThongTinTraCuu.Controls.Add(this.comboBoxSanBayDi);
            this.groupBoxThongTinTraCuu.Controls.Add(this.label2);
            this.groupBoxThongTinTraCuu.Controls.Add(this.label1);
            this.groupBoxThongTinTraCuu.Location = new System.Drawing.Point(14, 43);
            this.groupBoxThongTinTraCuu.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxThongTinTraCuu.Name = "groupBoxThongTinTraCuu";
            this.groupBoxThongTinTraCuu.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxThongTinTraCuu.Size = new System.Drawing.Size(839, 168);
            this.groupBoxThongTinTraCuu.TabIndex = 0;
            this.groupBoxThongTinTraCuu.TabStop = false;
            this.groupBoxThongTinTraCuu.Text = "Nhập Thông Tin Cần Tìm";
            // 
            // comboBoxMaChuyenBay
            // 
            this.comboBoxMaChuyenBay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMaChuyenBay.FormattingEnabled = true;
            this.comboBoxMaChuyenBay.Location = new System.Drawing.Point(216, 29);
            this.comboBoxMaChuyenBay.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxMaChuyenBay.Name = "comboBoxMaChuyenBay";
            this.comboBoxMaChuyenBay.Size = new System.Drawing.Size(200, 28);
            this.comboBoxMaChuyenBay.TabIndex = 17;
            this.comboBoxMaChuyenBay.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaChuyenBay_SelectedIndexChanged);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dateTimePickerDau);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateTimePickerCuoi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(494, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(299, 115);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày Khởi Hành";
            // 
            // dateTimePickerDau
            // 
            this.dateTimePickerDau.AccessibleDescription = "Click vào ngày giờ và nhập số tương ứng";
            this.dateTimePickerDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDau.Location = new System.Drawing.Point(136, 28);
            this.dateTimePickerDau.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePickerDau.Name = "dateTimePickerDau";
            this.dateTimePickerDau.Size = new System.Drawing.Size(148, 26);
            this.dateTimePickerDau.TabIndex = 4;
            this.dateTimePickerDau.ValueChanged += new System.EventHandler(this.dateTimePickerDau_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Đến ngày";
            // 
            // dateTimePickerCuoi
            // 
            this.dateTimePickerCuoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCuoi.Location = new System.Drawing.Point(136, 69);
            this.dateTimePickerCuoi.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePickerCuoi.Name = "dateTimePickerCuoi";
            this.dateTimePickerCuoi.Size = new System.Drawing.Size(148, 26);
            this.dateTimePickerCuoi.TabIndex = 5;
            this.dateTimePickerCuoi.ValueChanged += new System.EventHandler(this.dateTimePickerCuoi_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Từ ngày";
            // 
            // comboBoxSanBayDen
            // 
            this.comboBoxSanBayDen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSanBayDen.FormattingEnabled = true;
            this.comboBoxSanBayDen.Location = new System.Drawing.Point(216, 116);
            this.comboBoxSanBayDen.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxSanBayDen.Name = "comboBoxSanBayDen";
            this.comboBoxSanBayDen.Size = new System.Drawing.Size(200, 28);
            this.comboBoxSanBayDen.TabIndex = 1;
            this.comboBoxSanBayDen.SelectedIndexChanged += new System.EventHandler(this.comboBoxSanBayDen_SelectedIndexChanged);
            // 
            // comboBoxSanBayDi
            // 
            this.comboBoxSanBayDi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSanBayDi.FormattingEnabled = true;
            this.comboBoxSanBayDi.Location = new System.Drawing.Point(216, 73);
            this.comboBoxSanBayDi.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxSanBayDi.Name = "comboBoxSanBayDi";
            this.comboBoxSanBayDi.Size = new System.Drawing.Size(200, 28);
            this.comboBoxSanBayDi.TabIndex = 0;
            this.comboBoxSanBayDi.SelectedIndexChanged += new System.EventHandler(this.comboBoxSanBayDi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sân Bay Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sân Bay Đi";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonXuatTapTin);
            this.groupBox1.Location = new System.Drawing.Point(863, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(143, 83);
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
            this.buttonXuatTapTin.Click += new System.EventHandler(this.buttonXuatTapTin_Click);
            // 
            // buttonQuayVe
            // 
            this.buttonQuayVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuayVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuayVe.Location = new System.Drawing.Point(886, 549);
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
            this.groupBox3.Size = new System.Drawing.Size(872, 304);
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
            this.dataGridViewKQ.Size = new System.Drawing.Size(852, 182);
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
            // LichBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonQuayVe);
            this.Controls.Add(this.groupBoxThongTinTraCuu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1022, 638);
            this.Name = "LichBay";
            this.Text = "Tra Cứu Chuyến Bay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LichBay_FormClosing);
            this.Load += new System.EventHandler(this.LichBay_Load);
            this.groupBoxThongTinTraCuu.ResumeLayout(false);
            this.groupBoxThongTinTraCuu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinTraCuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerCuoi;
        private System.Windows.Forms.DateTimePicker dateTimePickerDau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonQuayVe;
        private System.Windows.Forms.Button buttonXuatTapTin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSanBayDen;
        private System.Windows.Forms.ComboBox comboBoxSanBayDi;
        private System.Windows.Forms.ComboBox comboBoxMaChuyenBay;
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
    }
}