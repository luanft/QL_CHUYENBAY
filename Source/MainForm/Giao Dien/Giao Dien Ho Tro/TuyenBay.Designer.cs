namespace MainForm
{
    partial class TuyenBay
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
            this._btThoat = new System.Windows.Forms.Button();
            this.groupBoxTuyenBay = new System.Windows.Forms.GroupBox();
            this.textBoxMaTuyenBay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSanBayDen = new System.Windows.Forms.ComboBox();
            this.comboBoxSanBayDi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagrvTuyenBay = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.groupBoxTuyenBay.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrvTuyenBay)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btThoat
            // 
            this._btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btThoat.Location = new System.Drawing.Point(524, 435);
            this._btThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btThoat.Name = "_btThoat";
            this._btThoat.Size = new System.Drawing.Size(123, 37);
            this._btThoat.TabIndex = 1;
            this._btThoat.Text = "Thoát";
            this._btThoat.UseVisualStyleBackColor = true;
            this._btThoat.Click += new System.EventHandler(this._btThoat_Click);
            // 
            // groupBoxTuyenBay
            // 
            this.groupBoxTuyenBay.Controls.Add(this.textBoxMaTuyenBay);
            this.groupBoxTuyenBay.Controls.Add(this.label3);
            this.groupBoxTuyenBay.Controls.Add(this.label2);
            this.groupBoxTuyenBay.Controls.Add(this.label1);
            this.groupBoxTuyenBay.Controls.Add(this.comboBoxSanBayDen);
            this.groupBoxTuyenBay.Controls.Add(this.comboBoxSanBayDi);
            this.groupBoxTuyenBay.Location = new System.Drawing.Point(13, 14);
            this.groupBoxTuyenBay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTuyenBay.Name = "groupBoxTuyenBay";
            this.groupBoxTuyenBay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxTuyenBay.Size = new System.Drawing.Size(495, 167);
            this.groupBoxTuyenBay.TabIndex = 2;
            this.groupBoxTuyenBay.TabStop = false;
            this.groupBoxTuyenBay.Text = "Thông tin Tuyến bay";
            // 
            // textBoxMaTuyenBay
            // 
            this.textBoxMaTuyenBay.Enabled = false;
            this.textBoxMaTuyenBay.Location = new System.Drawing.Point(199, 32);
            this.textBoxMaTuyenBay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMaTuyenBay.Name = "textBoxMaTuyenBay";
            this.textBoxMaTuyenBay.Size = new System.Drawing.Size(258, 26);
            this.textBoxMaTuyenBay.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Tuyến Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sân Bay Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sân Bay Đi";
            // 
            // comboBoxSanBayDen
            // 
            this.comboBoxSanBayDen.FormattingEnabled = true;
            this.comboBoxSanBayDen.Items.AddRange(new object[] {
            "Add New..."});
            this.comboBoxSanBayDen.Location = new System.Drawing.Point(199, 121);
            this.comboBoxSanBayDen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSanBayDen.Name = "comboBoxSanBayDen";
            this.comboBoxSanBayDen.Size = new System.Drawing.Size(258, 28);
            this.comboBoxSanBayDen.TabIndex = 1;
            this.comboBoxSanBayDen.SelectedIndexChanged += new System.EventHandler(this.comboBoxSanBayDen_SelectedIndexChanged);
            // 
            // comboBoxSanBayDi
            // 
            this.comboBoxSanBayDi.FormattingEnabled = true;
            this.comboBoxSanBayDi.Items.AddRange(new object[] {
            "Add New..."});
            this.comboBoxSanBayDi.Location = new System.Drawing.Point(199, 74);
            this.comboBoxSanBayDi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSanBayDi.Name = "comboBoxSanBayDi";
            this.comboBoxSanBayDi.Size = new System.Drawing.Size(258, 28);
            this.comboBoxSanBayDi.TabIndex = 0;
            this.comboBoxSanBayDi.SelectedIndexChanged += new System.EventHandler(this.comboBoxSanBayDi_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagrvTuyenBay);
            this.groupBox2.Location = new System.Drawing.Point(13, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(495, 281);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các Tuyến Bay Đã Thêm";
            // 
            // datagrvTuyenBay
            // 
            this.datagrvTuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrvTuyenBay.Location = new System.Drawing.Point(8, 28);
            this.datagrvTuyenBay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagrvTuyenBay.Name = "datagrvTuyenBay";
            this.datagrvTuyenBay.Size = new System.Drawing.Size(479, 243);
            this.datagrvTuyenBay.TabIndex = 0;
            this.datagrvTuyenBay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrvTuyenBay_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonLuu);
            this.groupBox3.Controls.Add(this.buttonSua);
            this.groupBox3.Location = new System.Drawing.Point(516, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(141, 264);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // buttonLuu
            // 
            this.buttonLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLuu.Location = new System.Drawing.Point(10, 77);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(123, 37);
            this.buttonLuu.TabIndex = 5;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSua.Location = new System.Drawing.Point(10, 29);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(123, 37);
            this.buttonSua.TabIndex = 2;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // TuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 479);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTuyenBay);
            this.Controls.Add(this._btThoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tuyến Bay";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this._keydown);
            this.groupBoxTuyenBay.ResumeLayout(false);
            this.groupBoxTuyenBay.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrvTuyenBay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btThoat;
        private System.Windows.Forms.GroupBox groupBoxTuyenBay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSanBayDen;
        private System.Windows.Forms.ComboBox comboBoxSanBayDi;
        private System.Windows.Forms.TextBox textBoxMaTuyenBay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datagrvTuyenBay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonLuu;
     
    }
}