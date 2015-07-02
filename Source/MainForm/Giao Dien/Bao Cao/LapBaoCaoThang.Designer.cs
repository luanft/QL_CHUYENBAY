namespace MainForm
{
    partial class BaoCaoThang
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.buttonBaoCaoThang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combox_Nam = new System.Windows.Forms.ComboBox();
            this.comboBox_Thang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQuayVe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.crystalReportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(18, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1008, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Doanh Thu";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(4, 24);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1000, 506);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.TabStop = false;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // buttonBaoCaoThang
            // 
            this.buttonBaoCaoThang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBaoCaoThang.Location = new System.Drawing.Point(384, 26);
            this.buttonBaoCaoThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBaoCaoThang.Name = "buttonBaoCaoThang";
            this.buttonBaoCaoThang.Size = new System.Drawing.Size(123, 37);
            this.buttonBaoCaoThang.TabIndex = 3;
            this.buttonBaoCaoThang.Text = "Lập báo cáo";
            this.buttonBaoCaoThang.UseVisualStyleBackColor = true;
            this.buttonBaoCaoThang.Click += new System.EventHandler(this.buttonBaoCaoThang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combox_Nam);
            this.groupBox2.Controls.Add(this.comboBox_Thang);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonBaoCaoThang);
            this.groupBox2.Location = new System.Drawing.Point(18, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(535, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Tháng, Năm";
            // 
            // combox_Nam
            // 
            this.combox_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_Nam.FormattingEnabled = true;
            this.combox_Nam.Location = new System.Drawing.Point(57, 28);
            this.combox_Nam.Name = "combox_Nam";
            this.combox_Nam.Size = new System.Drawing.Size(66, 28);
            this.combox_Nam.TabIndex = 1;
            this.combox_Nam.SelectedIndexChanged += new System.EventHandler(this.combox_Nam_SelectedIndexChanged);
            this.combox_Nam.SelectionChangeCommitted += new System.EventHandler(this.combox_Nam_SelectionChangeCommitted);
            // 
            // comboBox_Thang
            // 
            this.comboBox_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Thang.FormattingEnabled = true;
            this.comboBox_Thang.Location = new System.Drawing.Point(223, 28);
            this.comboBox_Thang.Name = "comboBox_Thang";
            this.comboBox_Thang.Size = new System.Drawing.Size(66, 28);
            this.comboBox_Thang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tháng";
            // 
            // buttonQuayVe
            // 
            this.buttonQuayVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuayVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuayVe.Location = new System.Drawing.Point(898, 44);
            this.buttonQuayVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonQuayVe.Name = "buttonQuayVe";
            this.buttonQuayVe.Size = new System.Drawing.Size(123, 37);
            this.buttonQuayVe.TabIndex = 4;
            this.buttonQuayVe.Text = "Đóng";
            this.buttonQuayVe.UseVisualStyleBackColor = true;
            this.buttonQuayVe.Click += new System.EventHandler(this.button4_Click);
            // 
            // BaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 663);
            this.Controls.Add(this.buttonQuayVe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1022, 691);
            this.Name = "BaoCaoThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Theo Tháng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaoCaoThang_FormClosing);
            this.Load += new System.EventHandler(this.BaoCaoThang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBaoCaoThang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuayVe;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox comboBox_Thang;
        private System.Windows.Forms.ComboBox combox_Nam;
    }
}