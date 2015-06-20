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
            this.buttonBaoCaoThang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxNam = new System.Windows.Forms.TextBox();
            this.textBoxThang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQuayVe = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
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
            // buttonBaoCaoThang
            // 
            this.buttonBaoCaoThang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBaoCaoThang.Location = new System.Drawing.Point(384, 26);
            this.buttonBaoCaoThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBaoCaoThang.Name = "buttonBaoCaoThang";
            this.buttonBaoCaoThang.Size = new System.Drawing.Size(123, 37);
            this.buttonBaoCaoThang.TabIndex = 2;
            this.buttonBaoCaoThang.Text = "Lập báo cáo";
            this.buttonBaoCaoThang.UseVisualStyleBackColor = true;
            this.buttonBaoCaoThang.Click += new System.EventHandler(this.buttonBaoCaoThang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxNam);
            this.groupBox2.Controls.Add(this.textBoxThang);
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
            // textBoxNam
            // 
            this.textBoxNam.Location = new System.Drawing.Point(58, 31);
            this.textBoxNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNam.Name = "textBoxNam";
            this.textBoxNam.Size = new System.Drawing.Size(62, 26);
            this.textBoxNam.TabIndex = 3;
            this.textBoxNam.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNamBaoCao_Validating);
            // 
            // textBoxThang
            // 
            this.textBoxThang.Location = new System.Drawing.Point(224, 31);
            this.textBoxThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxThang.Name = "textBoxThang";
            this.textBoxThang.Size = new System.Drawing.Size(56, 26);
            this.textBoxThang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tháng";
            // 
            // buttonQuayVe
            // 
            this.buttonQuayVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuayVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuayVe.Location = new System.Drawing.Point(899, 44);
            this.buttonQuayVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonQuayVe.Name = "buttonQuayVe";
            this.buttonQuayVe.Size = new System.Drawing.Size(123, 37);
            this.buttonQuayVe.TabIndex = 7;
            this.buttonQuayVe.Text = "Đóng";
            this.buttonQuayVe.UseVisualStyleBackColor = true;
            this.buttonQuayVe.Click += new System.EventHandler(this.button4_Click);
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
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // BaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 663);
            this.Controls.Add(this.buttonQuayVe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1055, 691);
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
        private System.Windows.Forms.TextBox textBoxNam;
        private System.Windows.Forms.TextBox textBoxThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuayVe;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}