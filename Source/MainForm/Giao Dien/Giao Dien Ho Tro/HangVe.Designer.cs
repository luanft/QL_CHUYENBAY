using System.Windows.Forms;
namespace MainForm.Giao_diện
{
    partial class HangVe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTiLeDonGia = new System.Windows.Forms.TextBox();
            this.textBoxTenHangVe = new System.Windows.Forms.TextBox();
            this.textBoxMaHangVe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSua = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHangVe = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            this._btThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHangVe)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTiLeDonGia);
            this.groupBox1.Controls.Add(this.textBoxTenHangVe);
            this.groupBox1.Controls.Add(this.textBoxMaHangVe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(468, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hạng Vé";
            // 
            // textBoxTiLeDonGia
            // 
            this.textBoxTiLeDonGia.Location = new System.Drawing.Point(249, 135);
            this.textBoxTiLeDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTiLeDonGia.Name = "textBoxTiLeDonGia";
            this.textBoxTiLeDonGia.Size = new System.Drawing.Size(198, 26);
            this.textBoxTiLeDonGia.TabIndex = 9;
            // 
            // textBoxTenHangVe
            // 
            this.textBoxTenHangVe.Location = new System.Drawing.Point(249, 87);
            this.textBoxTenHangVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTenHangVe.Name = "textBoxTenHangVe";
            this.textBoxTenHangVe.Size = new System.Drawing.Size(198, 26);
            this.textBoxTenHangVe.TabIndex = 8;
            // 
            // textBoxMaHangVe
            // 
            this.textBoxMaHangVe.Location = new System.Drawing.Point(249, 40);
            this.textBoxMaHangVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMaHangVe.Name = "textBoxMaHangVe";
            this.textBoxMaHangVe.ReadOnly = true;
            this.textBoxMaHangVe.Size = new System.Drawing.Size(198, 26);
            this.textBoxMaHangVe.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tỉ Lệ % Đơn Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Hạng Vé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Hạng Vé";
            // 
            // buttonSua
            // 
            this.buttonSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSua.Location = new System.Drawing.Point(20, 40);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(123, 37);
            this.buttonSua.TabIndex = 3;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewHangVe);
            this.groupBox3.Location = new System.Drawing.Point(13, 227);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(468, 253);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các Hạng Vé Đã Thêm";
            // 
            // dataGridViewHangVe
            // 
            this.dataGridViewHangVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHangVe.Location = new System.Drawing.Point(21, 26);
            this.dataGridViewHangVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewHangVe.Name = "dataGridViewHangVe";
            this.dataGridViewHangVe.Size = new System.Drawing.Size(436, 217);
            this.dataGridViewHangVe.TabIndex = 0;
            this.dataGridViewHangVe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHangVe_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonLuu);
            this.groupBox4.Controls.Add(this.buttonSua);
            this.groupBox4.Location = new System.Drawing.Point(489, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(162, 271);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // buttonLuu
            // 
            this.buttonLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLuu.Location = new System.Drawing.Point(20, 87);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(123, 37);
            this.buttonLuu.TabIndex = 10;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // _btThoat
            // 
            this._btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btThoat.Location = new System.Drawing.Point(509, 443);
            this._btThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btThoat.Name = "_btThoat";
            this._btThoat.Size = new System.Drawing.Size(123, 37);
            this._btThoat.TabIndex = 6;
            this._btThoat.Text = "Thoát";
            this._btThoat.UseVisualStyleBackColor = true;
            this._btThoat.Click += new System.EventHandler(this._btThoat_Click);
            // 
            // HangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 494);
            this.Controls.Add(this._btThoat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "HangVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Hạng Vé";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHangVe)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewHangVe;
        private System.Windows.Forms.TextBox textBoxTenHangVe;
        private System.Windows.Forms.TextBox textBoxMaHangVe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button _btThoat;
        private System.Windows.Forms.TextBox textBoxTiLeDonGia;
        private System.Windows.Forms.Button buttonLuu;
    }
}