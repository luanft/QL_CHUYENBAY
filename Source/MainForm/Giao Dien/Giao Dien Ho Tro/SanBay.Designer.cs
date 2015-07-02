namespace MainForm
{
    partial class SanBay
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxThongTInSanBay = new System.Windows.Forms.GroupBox();
            this.textBoxDiaChiSanBay = new System.Windows.Forms.TextBox();
            this.textBoxTenSanBay = new System.Windows.Forms.TextBox();
            this.textBoxMaSanBay = new System.Windows.Forms.TextBox();
            this.groupBoxThongTinCacSanBay = new System.Windows.Forms.GroupBox();
            this.dataGridViewSanBayDaThem = new System.Windows.Forms.DataGridView();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this._btThoat = new System.Windows.Forms.Button();
            this.toolTipThem = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMaSanBay = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDiaChiSanBay = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTenSanBay = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxThongTInSanBay.SuspendLayout();
            this.groupBoxThongTinCacSanBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanBayDaThem)).BeginInit();
            this.groupBoxChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sân Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sân Bay";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ Sân Bay";
            // 
            // groupBoxThongTInSanBay
            // 
            this.groupBoxThongTInSanBay.Controls.Add(this.textBoxDiaChiSanBay);
            this.groupBoxThongTInSanBay.Controls.Add(this.textBoxTenSanBay);
            this.groupBoxThongTInSanBay.Controls.Add(this.textBoxMaSanBay);
            this.groupBoxThongTInSanBay.Controls.Add(this.label1);
            this.groupBoxThongTInSanBay.Controls.Add(this.label3);
            this.groupBoxThongTInSanBay.Controls.Add(this.label2);
            this.groupBoxThongTInSanBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTInSanBay.Location = new System.Drawing.Point(13, 14);
            this.groupBoxThongTInSanBay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxThongTInSanBay.Name = "groupBoxThongTInSanBay";
            this.groupBoxThongTInSanBay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxThongTInSanBay.Size = new System.Drawing.Size(608, 139);
            this.groupBoxThongTInSanBay.TabIndex = 3;
            this.groupBoxThongTInSanBay.TabStop = false;
            this.groupBoxThongTInSanBay.Text = "Thông Tin Sân Bay";
            // 
            // textBoxDiaChiSanBay
            // 
            this.textBoxDiaChiSanBay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDiaChiSanBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiaChiSanBay.Location = new System.Drawing.Point(145, 89);
            this.textBoxDiaChiSanBay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDiaChiSanBay.Name = "textBoxDiaChiSanBay";
            this.textBoxDiaChiSanBay.Size = new System.Drawing.Size(420, 26);
            this.textBoxDiaChiSanBay.TabIndex = 5;
            this.toolTipDiaChiSanBay.SetToolTip(this.textBoxDiaChiSanBay, "Nhập vào địa chỉ sân bay");
            // 
            // textBoxTenSanBay
            // 
            this.textBoxTenSanBay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTenSanBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenSanBay.Location = new System.Drawing.Point(392, 38);
            this.textBoxTenSanBay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTenSanBay.Name = "textBoxTenSanBay";
            this.textBoxTenSanBay.Size = new System.Drawing.Size(173, 26);
            this.textBoxTenSanBay.TabIndex = 4;
            this.toolTipTenSanBay.SetToolTip(this.textBoxTenSanBay, "Nhập vào tên sân bay");
            // 
            // textBoxMaSanBay
            // 
            this.textBoxMaSanBay.Enabled = false;
            this.textBoxMaSanBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaSanBay.Location = new System.Drawing.Point(145, 38);
            this.textBoxMaSanBay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMaSanBay.Name = "textBoxMaSanBay";
            this.textBoxMaSanBay.Size = new System.Drawing.Size(119, 26);
            this.textBoxMaSanBay.TabIndex = 3;
            this.toolTipMaSanBay.SetToolTip(this.textBoxMaSanBay, "Mã Sân Bay được phát sinh tự động");
            // 
            // groupBoxThongTinCacSanBay
            // 
            this.groupBoxThongTinCacSanBay.Controls.Add(this.dataGridViewSanBayDaThem);
            this.groupBoxThongTinCacSanBay.Location = new System.Drawing.Point(13, 163);
            this.groupBoxThongTinCacSanBay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxThongTinCacSanBay.Name = "groupBoxThongTinCacSanBay";
            this.groupBoxThongTinCacSanBay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxThongTinCacSanBay.Size = new System.Drawing.Size(608, 318);
            this.groupBoxThongTinCacSanBay.TabIndex = 4;
            this.groupBoxThongTinCacSanBay.TabStop = false;
            this.groupBoxThongTinCacSanBay.Text = "Các Sân Bay Đã Thêm";
            // 
            // dataGridViewSanBayDaThem
            // 
            this.dataGridViewSanBayDaThem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSanBayDaThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanBayDaThem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C,
            this.Column1,
            this.Column2});
            this.dataGridViewSanBayDaThem.Location = new System.Drawing.Point(8, 29);
            this.dataGridViewSanBayDaThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSanBayDaThem.Name = "dataGridViewSanBayDaThem";
            this.dataGridViewSanBayDaThem.Size = new System.Drawing.Size(569, 259);
            this.dataGridViewSanBayDaThem.TabIndex = 0;
            this.dataGridViewSanBayDaThem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanBayDaThem_CellContentClick);
            // 
            // C
            // 
            this.C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.C.DataPropertyName = "Mã Sân Bay";
            this.C.HeaderText = "Mã Sân Bay";
            this.C.Name = "C";
            this.C.Width = 172;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Tên Sân Bay";
            this.Column1.HeaderText = "Tên Sân Bay";
            this.Column1.Name = "Column1";
            this.Column1.Width = 174;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "Địa Chỉ Sân Bay";
            this.Column2.HeaderText = "Địa Chỉ Sân Bay";
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.btnLuu);
            this.groupBoxChucNang.Controls.Add(this.btnSua);
            this.groupBoxChucNang.Location = new System.Drawing.Point(640, 14);
            this.groupBoxChucNang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxChucNang.Size = new System.Drawing.Size(141, 264);
            this.groupBoxChucNang.TabIndex = 5;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Chức năng";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(10, 92);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(123, 37);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.buttonLuu_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(10, 38);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 37);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // _btThoat
            // 
            this._btThoat.Location = new System.Drawing.Point(629, 444);
            this._btThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btThoat.Name = "_btThoat";
            this._btThoat.Size = new System.Drawing.Size(123, 37);
            this._btThoat.TabIndex = 4;
            this._btThoat.Text = "Thoát";
            this._btThoat.UseVisualStyleBackColor = true;
            this._btThoat.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // toolTipThem
            // 
            this.toolTipThem.AutomaticDelay = 0;
            this.toolTipThem.AutoPopDelay = 0;
            this.toolTipThem.InitialDelay = 500;
            this.toolTipThem.ReshowDelay = 100;
            this.toolTipThem.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipMaSanBay
            // 
            this.toolTipMaSanBay.AutomaticDelay = 0;
            this.toolTipMaSanBay.AutoPopDelay = 0;
            this.toolTipMaSanBay.InitialDelay = 500;
            this.toolTipMaSanBay.ReshowDelay = 100;
            this.toolTipMaSanBay.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipDiaChiSanBay
            // 
            this.toolTipDiaChiSanBay.AutomaticDelay = 0;
            this.toolTipDiaChiSanBay.AutoPopDelay = 0;
            this.toolTipDiaChiSanBay.InitialDelay = 500;
            this.toolTipDiaChiSanBay.ReshowDelay = 100;
            this.toolTipDiaChiSanBay.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipTenSanBay
            // 
            this.toolTipTenSanBay.AutomaticDelay = 0;
            this.toolTipTenSanBay.AutoPopDelay = 0;
            this.toolTipTenSanBay.InitialDelay = 500;
            this.toolTipTenSanBay.ReshowDelay = 100;
            this.toolTipTenSanBay.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // SanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 492);
            this.Controls.Add(this._btThoat);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBoxThongTinCacSanBay);
            this.Controls.Add(this.groupBoxThongTInSanBay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SanBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sân Bay";
            this.toolTipThem.SetToolTip(this, "Click vào button này để thêm một sân bay mới ");
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this._KeyDown);
            this.groupBoxThongTInSanBay.ResumeLayout(false);
            this.groupBoxThongTInSanBay.PerformLayout();
            this.groupBoxThongTinCacSanBay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanBayDaThem)).EndInit();
            this.groupBoxChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxThongTInSanBay;
        private System.Windows.Forms.TextBox textBoxMaSanBay;
        private System.Windows.Forms.GroupBox groupBoxThongTinCacSanBay;
        private System.Windows.Forms.TextBox textBoxDiaChiSanBay;
        private System.Windows.Forms.TextBox textBoxTenSanBay;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button _btThoat;
        private System.Windows.Forms.DataGridView dataGridViewSanBayDaThem;
        private System.Windows.Forms.ToolTip toolTipThem;
        private System.Windows.Forms.ToolTip toolTipMaSanBay;
        private System.Windows.Forms.ToolTip toolTipDiaChiSanBay;
        private System.Windows.Forms.ToolTip toolTipTenSanBay;
        private System.Windows.Forms.Button btnLuu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}