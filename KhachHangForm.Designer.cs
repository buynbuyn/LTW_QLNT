namespace QLNT
{
    partial class KhachHangForm
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
            dgvKhachHang = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(12, 82);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(1153, 431);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(293, 27);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Nhập...";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(311, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(1022, 47);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(143, 29);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm khách hàng";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // KhachHangForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 525);
            Controls.Add(btnThem);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvKhachHang);
            Name = "KhachHangForm";
            Text = "KhachHangForm";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKhachHang;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnThem;
    }
}