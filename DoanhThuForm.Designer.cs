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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            cboMonth = new ComboBox();
            cboYear = new ComboBox();
            btnTheoNgay = new Button();
            btnTheoThang = new Button();
            lblTotal = new Label();
            lblTotalBills = new Label();
            label1 = new Label();
            chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnExportExcel = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).BeginInit();
            SuspendLayout();
            // 
            // cboMonth
            // 
            cboMonth.FormattingEnabled = true;
            cboMonth.Location = new Point(853, 122);
            cboMonth.Name = "cboMonth";
            cboMonth.Size = new Size(69, 28);
            cboMonth.TabIndex = 0;
            // 
            // cboYear
            // 
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(1007, 122);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(115, 28);
            cboYear.TabIndex = 1;
            // 
            // btnTheoNgay
            // 
            btnTheoNgay.Location = new Point(794, 313);
            btnTheoNgay.Name = "btnTheoNgay";
            btnTheoNgay.Size = new Size(328, 58);
            btnTheoNgay.TabIndex = 2;
            btnTheoNgay.Text = "Xem doanh thu theo ngày";
            btnTheoNgay.UseVisualStyleBackColor = true;
            btnTheoNgay.Click += btnTheoNgay_Click;
            // 
            // btnTheoThang
            // 
            btnTheoThang.Location = new Point(794, 409);
            btnTheoThang.Name = "btnTheoThang";
            btnTheoThang.Size = new Size(328, 61);
            btnTheoThang.TabIndex = 3;
            btnTheoThang.Text = "Xem doanh thu theo tháng";
            btnTheoThang.UseVisualStyleBackColor = true;
            btnTheoThang.Click += btnTheoThang_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(730, 651);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(117, 40);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Tổng doanh thu:\n\n";
            // 
            // lblTotalBills
            // 
            lblTotalBills.AutoSize = true;
            lblTotalBills.Location = new Point(318, 293);
            lblTotalBills.Name = "lblTotalBills";
            lblTotalBills.Size = new Size(0, 20);
            lblTotalBills.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 30F, FontStyle.Bold);
            label1.Location = new Point(794, 20);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(331, 57);
            label1.TabIndex = 7;
            label1.Text = "DOANH THU";
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRevenue.Legends.Add(legend1);
            chartRevenue.Location = new Point(12, 92);
            chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRevenue.Series.Add(series1);
            chartRevenue.Size = new Size(682, 604);
            chartRevenue.TabIndex = 8;
            chartRevenue.Text = "chart1";
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(1027, 635);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(189, 53);
            btnExportExcel.TabIndex = 9;
            btnExportExcel.Text = "Xuất file excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(957, 130);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 15;
            label3.Text = "Năm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(794, 130);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 14;
            label2.Text = "Tháng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(794, 270);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 16;
            label4.Text = "Chọn chế độ xem:";
            // 
            // DoanhThuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 708);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnExportExcel);
            Controls.Add(chartRevenue);
            Controls.Add(label1);
            Controls.Add(lblTotalBills);
            Controls.Add(lblTotal);
            Controls.Add(btnTheoThang);
            Controls.Add(btnTheoNgay);
            Controls.Add(cboYear);
            Controls.Add(cboMonth);
            Name = "DoanhThuForm";
            Text = "DoanhThuForm";
            ((System.ComponentModel.ISupportInitialize)chartRevenue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMonth;
        private ComboBox cboYear;
        private Button btnTheoNgay;
        private Button btnTheoThang;
        private Label lblTotal;
        private Label lblTotalBills;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private Button btnExportExcel;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}