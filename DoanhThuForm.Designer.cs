namespace QLNT
{
    partial class DoanhThuForm
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
            cboMonth = new ComboBox();
            cboYear = new ComboBox();
            btnTheoNgay = new Button();
            btnTheoThang = new Button();
            dgvRevenue = new DataGridView();
            lblTotal = new Label();
            lblTotalBills = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).BeginInit();
            SuspendLayout();
            // 
            // cboMonth
            // 
            cboMonth.FormattingEnabled = true;
            cboMonth.Location = new Point(356, 91);
            cboMonth.Name = "cboMonth";
            cboMonth.Size = new Size(87, 28);
            cboMonth.TabIndex = 0;
            // 
            // cboYear
            // 
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(449, 91);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(115, 28);
            cboYear.TabIndex = 1;
            // 
            // btnTheoNgay
            // 
            btnTheoNgay.Location = new Point(356, 125);
            btnTheoNgay.Name = "btnTheoNgay";
            btnTheoNgay.Size = new Size(208, 29);
            btnTheoNgay.TabIndex = 2;
            btnTheoNgay.Text = "Xem doanh thu theo ngày";
            btnTheoNgay.UseVisualStyleBackColor = true;
            btnTheoNgay.Click += btnTheoNgay_Click;
            // 
            // btnTheoThang
            // 
            btnTheoThang.Location = new Point(356, 160);
            btnTheoThang.Name = "btnTheoThang";
            btnTheoThang.Size = new Size(208, 29);
            btnTheoThang.TabIndex = 3;
            btnTheoThang.Text = "Xem doanh thu theo tháng";
            btnTheoThang.UseVisualStyleBackColor = true;
            btnTheoThang.Click += btnTheoThang_Click;
            // 
            // dgvRevenue
            // 
            dgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenue.Location = new Point(12, 91);
            dgvRevenue.Name = "dgvRevenue";
            dgvRevenue.RowHeadersWidth = 51;
            dgvRevenue.Size = new Size(338, 272);
            dgvRevenue.TabIndex = 4;
            dgvRevenue.CellContentClick += dgvRevenue_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(356, 323);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(117, 40);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Tổng doanh thu:\n\n";
            // 
            // lblTotalBills
            // 
            lblTotalBills.AutoSize = true;
            lblTotalBills.Location = new Point(356, 292);
            lblTotalBills.Name = "lblTotalBills";
            lblTotalBills.Size = new Size(0, 20);
            lblTotalBills.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 38);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(162, 29);
            label1.TabIndex = 7;
            label1.Text = "DOANH THU";
            // 
            // DoanhThuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 450);
            Controls.Add(label1);
            Controls.Add(lblTotalBills);
            Controls.Add(lblTotal);
            Controls.Add(dgvRevenue);
            Controls.Add(btnTheoThang);
            Controls.Add(btnTheoNgay);
            Controls.Add(cboYear);
            Controls.Add(cboMonth);
            Name = "DoanhThuForm";
            Text = "DoanhThuForm";
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMonth;
        private ComboBox cboYear;
        private Button btnTheoNgay;
        private Button btnTheoThang;
        private DataGridView dgvRevenue;
        private Label lblTotal;
        private Label lblTotalBills;
        private Label label1;
    }
}