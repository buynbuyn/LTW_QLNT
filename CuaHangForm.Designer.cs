namespace QLNT
{
    partial class CuaHangForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            findProduct = new TextBox();
            btn_findProduct = new Button();
            dataGridView1 = new DataGridView();
            cboTenSanPham = new ComboBox();
            label4 = new Label();
            txtSoLuongMua = new TextBox();
            btnThemVaoGioHang = new Button();
            label5 = new Label();
            pnlChiTietSanPham = new Panel();
            cboMaSanPham = new ComboBox();
            label3 = new Label();
            pnlTimKiem = new Panel();
            mathuoc = new DataGridViewTextBoxColumn();
            tenthuoc = new DataGridViewTextBoxColumn();
            hamluong = new DataGridViewTextBoxColumn();
            donvitinh = new DataGridViewTextBoxColumn();
            dongia = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlChiTietSanPham.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(563, 19);
            label1.Name = "label1";
            label1.Size = new Size(329, 46);
            label1.TabIndex = 0;
            label1.Text = "CỬA HÀNG THUỐC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(292, 32);
            label2.TabIndex = 1;
            label2.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // findProduct
            // 
            findProduct.Font = new Font("Segoe UI", 13F);
            findProduct.Location = new Point(800, 10);
            findProduct.Name = "findProduct";
            findProduct.PlaceholderText = "Nhập tên hoặc mã sản phẩm...";
            findProduct.Size = new Size(350, 36);
            findProduct.TabIndex = 2;
            findProduct.Enter += findProduct_Enter;
            findProduct.Leave += findProduct_Leave;
            // 
            // btn_findProduct
            // 
            btn_findProduct.BackColor = Color.LightSkyBlue;
            btn_findProduct.FlatAppearance.BorderSize = 0;
            btn_findProduct.FlatStyle = FlatStyle.Flat;
            btn_findProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_findProduct.ForeColor = Color.White;
            btn_findProduct.Location = new Point(1160, 10);
            btn_findProduct.Name = "btn_findProduct";
            btn_findProduct.Size = new Size(120, 38);
            btn_findProduct.TabIndex = 3;
            btn_findProduct.Text = "Tìm kiếm";
            btn_findProduct.UseVisualStyleBackColor = false;
            btn_findProduct.Click += btn_findProduct_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { mathuoc, tenthuoc, hamluong, donvitinh, dongia });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(24, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1294, 617);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cboTenSanPham
            // 
            cboTenSanPham.Font = new Font("Segoe UI", 14F);
            cboTenSanPham.FormattingEnabled = true;
            cboTenSanPham.Location = new Point(30, 118);
            cboTenSanPham.Name = "cboTenSanPham";
            cboTenSanPham.Size = new Size(339, 39);
            cboTenSanPham.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(30, 287);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 7;
            label4.Text = "Số lượng mua:";
            // 
            // txtSoLuongMua
            // 
            txtSoLuongMua.Font = new Font("Segoe UI", 14F);
            txtSoLuongMua.Location = new Point(30, 315);
            txtSoLuongMua.Name = "txtSoLuongMua";
            txtSoLuongMua.Size = new Size(339, 39);
            txtSoLuongMua.TabIndex = 8;
            txtSoLuongMua.TextAlign = HorizontalAlignment.Right;
            // 
            // btnThemVaoGioHang
            // 
            btnThemVaoGioHang.BackColor = Color.ForestGreen;
            btnThemVaoGioHang.FlatAppearance.BorderSize = 0;
            btnThemVaoGioHang.FlatStyle = FlatStyle.Flat;
            btnThemVaoGioHang.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnThemVaoGioHang.ForeColor = Color.White;
            btnThemVaoGioHang.Location = new Point(30, 391);
            btnThemVaoGioHang.Name = "btnThemVaoGioHang";
            btnThemVaoGioHang.Size = new Size(339, 60);
            btnThemVaoGioHang.TabIndex = 9;
            btnThemVaoGioHang.Text = "THÊM VÀO GIỎ HÀNG";
            btnThemVaoGioHang.UseVisualStyleBackColor = false;
            btnThemVaoGioHang.Click += btnThemVaoGioHang_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(30, 90);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 10;
            label5.Text = "Tên sản phẩm:";
            // 
            // pnlChiTietSanPham
            // 
            pnlChiTietSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlChiTietSanPham.BackColor = Color.Azure;
            pnlChiTietSanPham.BorderStyle = BorderStyle.FixedSingle;
            pnlChiTietSanPham.Controls.Add(cboMaSanPham);
            pnlChiTietSanPham.Controls.Add(label3);
            pnlChiTietSanPham.Controls.Add(label5);
            pnlChiTietSanPham.Controls.Add(btnThemVaoGioHang);
            pnlChiTietSanPham.Controls.Add(txtSoLuongMua);
            pnlChiTietSanPham.Controls.Add(label4);
            pnlChiTietSanPham.Controls.Add(cboTenSanPham);
            pnlChiTietSanPham.Font = new Font("Segoe UI", 14F);
            pnlChiTietSanPham.Location = new Point(1050, 150);
            pnlChiTietSanPham.Name = "pnlChiTietSanPham";
            pnlChiTietSanPham.Size = new Size(400, 621);
            pnlChiTietSanPham.TabIndex = 0;
            // 
            // cboMaSanPham
            // 
            cboMaSanPham.Font = new Font("Segoe UI", 14F);
            cboMaSanPham.FormattingEnabled = true;
            cboMaSanPham.Location = new Point(30, 212);
            cboMaSanPham.Name = "cboMaSanPham";
            cboMaSanPham.Size = new Size(339, 39);
            cboMaSanPham.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(30, 184);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 11;
            label3.Text = "Mã sản phẩm:";
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(label2);
            pnlTimKiem.Controls.Add(findProduct);
            pnlTimKiem.Controls.Add(btn_findProduct);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(0, 0);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1481, 60);
            pnlTimKiem.TabIndex = 1;
            // 
            // mathuoc
            // 
            mathuoc.HeaderText = "Mã thuốc";
            mathuoc.MinimumWidth = 6;
            mathuoc.Name = "mathuoc";
            mathuoc.Width = 250;
            // 
            // tenthuoc
            // 
            tenthuoc.HeaderText = "Tên thuốc";
            tenthuoc.MinimumWidth = 6;
            tenthuoc.Name = "tenthuoc";
            tenthuoc.Width = 250;
            // 
            // hamluong
            // 
            hamluong.HeaderText = "Hàm lượng";
            hamluong.MinimumWidth = 6;
            hamluong.Name = "hamluong";
            hamluong.Width = 250;
            // 
            // donvitinh
            // 
            donvitinh.HeaderText = "Đơn vị tính";
            donvitinh.MinimumWidth = 6;
            donvitinh.Name = "donvitinh";
            donvitinh.Width = 250;
            // 
            // dongia
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dongia.DefaultCellStyle = dataGridViewCellStyle3;
            dongia.HeaderText = "Đơn giá (VNĐ)";
            dongia.MinimumWidth = 6;
            dongia.Name = "dongia";
            dongia.Width = 250;
            // 
            // CuaHangForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 804);
            Controls.Add(pnlChiTietSanPham);
            Controls.Add(pnlTimKiem);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CuaHangForm";
            Text = "Quản lý Cửa Hàng Thuốc";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlChiTietSanPham.ResumeLayout(false);
            pnlChiTietSanPham.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Khai báo các control đã đổi tên
        private Label label1;
        private Label label2;
        private TextBox findProduct;
        private Button btn_findProduct;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox txtSoLuongMua;
        private Button btnThemVaoGioHang;
        private Label label5;
        private ComboBox cboTenSanPham;
        private Panel pnlChiTietSanPham; // Khai báo Panel mới
        private Panel pnlTimKiem; // Khai báo Panel mới
        private ComboBox cboMaSanPham;
        private Label label3;
        private DataGridViewTextBoxColumn mathuoc;
        private DataGridViewTextBoxColumn tenthuoc;
        private DataGridViewTextBoxColumn hamluong;
        private DataGridViewTextBoxColumn donvitinh;
        private DataGridViewTextBoxColumn dongia;
    }
}