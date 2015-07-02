namespace MainForm.Giao_Dien.Tra_Cuu
{
    partial class DuLieu
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
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.dgvDuLieu = new System.Windows.Forms.DataGridView();
            this.lbTraCuuDuLieu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xem Danh Sách";
            // 
            // cbLoai
            // 
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "Nhân viên",
            "Nhóm người dùng",
            "Tuyến bay",
            "Phiếu đặt chổ",
            "Vé",
            "Quyền hạn",
            "Sân Bay",
            "Hang vé",
            "Tham số"});
            this.cbLoai.Location = new System.Drawing.Point(173, 90);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(121, 21);
            this.cbLoai.TabIndex = 1;
            this.cbLoai.SelectionChangeCommitted += new System.EventHandler(this.cbLoai_SelectionChangeCommitted);
            // 
            // dgvDuLieu
            // 
            this.dgvDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuLieu.Location = new System.Drawing.Point(12, 166);
            this.dgvDuLieu.Name = "dgvDuLieu";
            this.dgvDuLieu.Size = new System.Drawing.Size(764, 343);
            this.dgvDuLieu.TabIndex = 2;
            // 
            // lbTraCuuDuLieu
            // 
            this.lbTraCuuDuLieu.AutoSize = true;
            this.lbTraCuuDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTraCuuDuLieu.Location = new System.Drawing.Point(299, 21);
            this.lbTraCuuDuLieu.Name = "lbTraCuuDuLieu";
            this.lbTraCuuDuLieu.Size = new System.Drawing.Size(228, 33);
            this.lbTraCuuDuLieu.TabIndex = 3;
            this.lbTraCuuDuLieu.Text = "Tra Cứu Dữ Liệu";
            // 
            // DuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 521);
            this.Controls.Add(this.lbTraCuuDuLieu);
            this.Controls.Add(this.dgvDuLieu);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.label1);
            this.Name = "DuLieu";
            this.Text = "Tra cứu dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.DataGridView dgvDuLieu;
        private System.Windows.Forms.Label lbTraCuuDuLieu;
    }
}