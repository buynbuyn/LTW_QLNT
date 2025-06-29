namespace QLNT
{
    partial class LSHDForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            lblTitle = new Label();
            dgvOrders = new DataGridView();
            pnlHeader = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlFilter = new Panel();
            btnFilter = new Button();
            cbYear = new ComboBox();
            cbMonth = new ComboBox();
            cbDay = new ComboBox();
            lblFilterByDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            pnlHeader.SuspendLayout();
            pnlFilter.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "LỊCH SỬ HÓA ĐƠN";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = SystemColors.ControlLightLight;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.ColumnHeadersHeight = 35;
            dgvOrders.EnableHeadersVisualStyles = false;
            dgvOrders.Location = new Point(20, 220);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvOrders.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvOrders.RowTemplate.Height = 25;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(744, 260);
            dgvOrders.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.AliceBlue;
            pnlHeader.Controls.Add(btnSearch);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Controls.Add(lblSearch);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(784, 80);
            pnlHeader.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(620, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(400, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên khách hàng...";
            txtSearch.Size = new Size(200, 25);
            txtSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.DarkSlateGray;
            lblSearch.Location = new Point(320, 32);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(74, 20);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = SystemColors.ControlLight;
            pnlFilter.Controls.Add(btnFilter);
            pnlFilter.Controls.Add(cbYear);
            pnlFilter.Controls.Add(cbMonth);
            pnlFilter.Controls.Add(cbDay);
            pnlFilter.Controls.Add(lblFilterByDate);
            pnlFilter.Controls.Add(lblTitle);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 80);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(784, 120);
            pnlFilter.TabIndex = 10;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.SteelBlue;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(380, 72);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(80, 30);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "Lọc";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // cbYear
            // 
            cbYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(290, 75);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(80, 25);
            cbYear.TabIndex = 7;
            // 
            // cbMonth
            // 
            cbMonth.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(210, 75);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(70, 25);
            cbMonth.TabIndex = 6;
            // 
            // cbDay
            // 
            cbDay.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDay.FormattingEnabled = true;
            cbDay.Location = new Point(140, 75);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(60, 25);
            cbDay.TabIndex = 5;
            // 
            // lblFilterByDate
            // 
            lblFilterByDate.AutoSize = true;
            lblFilterByDate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterByDate.ForeColor = Color.DarkSlateGray;
            lblFilterByDate.Location = new Point(20, 77);
            lblFilterByDate.Name = "lblFilterByDate";
            lblFilterByDate.Size = new Size(106, 20);
            lblFilterByDate.TabIndex = 4;
            lblFilterByDate.Text = "Lọc theo ngày:";
            // 
            // LSHDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 500);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Controls.Add(dgvOrders);
            MinimumSize = new Size(800, 500);
            Name = "LSHDForm";
            Text = "Lịch sử hóa đơn";
            Load += LSHDForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Khai báo các controls
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFilterByDate;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button btnFilter;
        private Panel pnlHeader;
        private Label lblSearch;
        private Panel pnlFilter;
    }
}