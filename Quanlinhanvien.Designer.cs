namespace QLNT
{
    partial class Quanlinhanvien
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
            this.components = new System.ComponentModel.Container(); // Giữ lại dòng này

            // Khai báo các Controls
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLeftSidebar = new System.Windows.Forms.Panel();
            this.pnlThemeSettings = new System.Windows.Forms.Panel();
            this.lblThemeSettings = new System.Windows.Forms.Label();
            this.flowPnlColors = new System.Windows.Forms.FlowLayoutPanel(); // Để chứa các ô màu
            this.pnlReport = new System.Windows.Forms.Panel();
            this.lblReport = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtSearchFilter = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox(); // Ví dụ bộ lọc
            this.chkInactive = new System.Windows.Forms.CheckBox(); // Ví dụ bộ lọc
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDoLuong = new System.Windows.Forms.Button();
            this.btnThietLap = new System.Windows.Forms.Button();
            this.btnDiChuyen = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCapLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();


            // Bắt đầu SuspendLayout để tối ưu hóa việc thiết kế
            this.pnlMain.SuspendLayout();
            this.pnlLeftSidebar.SuspendLayout();
            this.pnlThemeSettings.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();

            //
            // pnlMain (Main Panel)
            //
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlLeftSidebar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 100); // Dưới thanh toolbar
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 600); // Kích thước ước tính
            this.pnlMain.TabIndex = 0;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48))))); // Màu nền tổng thể

            //
            // pnlLeftSidebar (Sidebar bên trái)
            //
            this.pnlLeftSidebar.Controls.Add(this.pnlThemeSettings);
            this.pnlLeftSidebar.Controls.Add(this.pnlReport);
            this.pnlLeftSidebar.Controls.Add(this.pnlFilter);
            this.pnlLeftSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftSidebar.Name = "pnlLeftSidebar";
            this.pnlLeftSidebar.Size = new System.Drawing.Size(250, 600);
            this.pnlLeftSidebar.TabIndex = 0;
            this.pnlLeftSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38))))); // Màu nền sidebar
            this.pnlLeftSidebar.Padding = new System.Windows.Forms.Padding(10); // Khoảng cách lề
            //
            // pnlFilter (Panel Bộ lọc)
            //
            this.pnlFilter.Controls.Add(this.chkInactive);
            this.pnlFilter.Controls.Add(this.chkActive);
            this.pnlFilter.Controls.Add(this.txtSearchFilter);
            this.pnlFilter.Controls.Add(this.lblFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(10, 10);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(230, 200);
            this.pnlFilter.TabIndex = 0;
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55))))); // Màu nền panel
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(10);
            //
            // lblFilter
            //
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(5, 5);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(71, 28);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Bộ lọc";
            //
            // txtSearchFilter
            //
            this.txtSearchFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtSearchFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFilter.ForeColor = System.Drawing.Color.White;
            this.txtSearchFilter.Location = new System.Drawing.Point(5, 40);
            this.txtSearchFilter.Name = "txtSearchFilter";
            this.txtSearchFilter.PlaceholderText = "Tìm kiếm...";
            this.txtSearchFilter.Size = new System.Drawing.Size(220, 30);
            this.txtSearchFilter.TabIndex = 1;
            //
            // chkActive
            //
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.ForeColor = System.Drawing.Color.White;
            this.chkActive.Location = new System.Drawing.Point(5, 80);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(109, 27);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Đang hoạt động";
            this.chkActive.UseVisualStyleBackColor = true;
            //
            // chkInactive
            //
            this.chkInactive.AutoSize = true;
            this.chkInactive.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInactive.ForeColor = System.Drawing.Color.White;
            this.chkInactive.Location = new System.Drawing.Point(5, 110);
            this.chkInactive.Name = "chkInactive";
            this.chkInactive.Size = new System.Drawing.Size(117, 27);
            this.chkInactive.TabIndex = 3;
            this.chkInactive.Text = "Ngừng hoạt động";
            this.chkInactive.UseVisualStyleBackColor = true;

            //
            // pnlReport (Panel Báo cáo)
            //
            this.pnlReport.Controls.Add(this.lblReport);
            this.pnlReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReport.Location = new System.Drawing.Point(10, 220); // Dưới pnlFilter + 10px padding
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(230, 80);
            this.pnlReport.TabIndex = 1;
            this.pnlReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.pnlReport.Padding = new System.Windows.Forms.Padding(10);
            //
            // lblReport
            //
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.Color.White;
            this.lblReport.Location = new System.Drawing.Point(5, 5);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(83, 28);
            this.lblReport.TabIndex = 0;
            this.lblReport.Text = "Báo cáo";

            //
            // pnlThemeSettings (Panel Thiết lập giao diện)
            //
            this.pnlThemeSettings.Controls.Add(this.flowPnlColors);
            this.pnlThemeSettings.Controls.Add(this.lblThemeSettings);
            this.pnlThemeSettings.Dock = System.Windows.Forms.DockStyle.Bottom; // Đặt ở dưới cùng của sidebar
            this.pnlThemeSettings.Location = new System.Drawing.Point(10, 400); // Ước tính vị trí
            this.pnlThemeSettings.Name = "pnlThemeSettings";
            this.pnlThemeSettings.Size = new System.Drawing.Size(230, 190);
            this.pnlThemeSettings.TabIndex = 2;
            this.pnlThemeSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.pnlThemeSettings.Padding = new System.Windows.Forms.Padding(10);
            //
            // lblThemeSettings
            //
            this.lblThemeSettings.AutoSize = true;
            this.lblThemeSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemeSettings.ForeColor = System.Drawing.Color.White;
            this.lblThemeSettings.Location = new System.Drawing.Point(5, 5);
            this.lblThemeSettings.Name = "lblThemeSettings";
            this.lblThemeSettings.Size = new System.Drawing.Size(164, 28);
            this.lblThemeSettings.TabIndex = 0;
            this.lblThemeSettings.Text = "Thiết lập giao diện";
            //
            // flowPnlColors (FlowLayoutPanel cho các ô màu)
            //
            this.flowPnlColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPnlColors.Location = new System.Drawing.Point(10, 40);
            this.flowPnlColors.Name = "flowPnlColors";
            this.flowPnlColors.Size = new System.Drawing.Size(210, 140);
            this.flowPnlColors.TabIndex = 1;
            // Thêm các ô màu nhỏ vào đây trong runtime hoặc designer
            // Ví dụ: flowPnlColors.Controls.Add(CreateColorBox(Color.Red));

            //
            // pnlContent (Panel chứa DataGridView)
            //
            this.pnlContent.Controls.Add(this.dgvNhanVien);
            this.pnlContent.Controls.Add(this.pnlFooter);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 0); // Bên phải sidebar
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(950, 600); // Kích thước ước tính
            this.pnlContent.TabIndex = 1;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48))))); // Màu nền

            //
            // dgvNhanVien (DataGridView)
            //
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48))))); // Màu nền DataGridView
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None; // Bỏ viền
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))); // Màu nền header
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White; // Màu chữ header
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeight = 35; // Chiều cao header
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colPhongBan,
            this.colChucVu,
            this.colDienThoai,
            this.colEmail});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.EnableHeadersVisualStyles = false; // Quan trọng để tùy chỉnh header
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))); // Màu đường kẻ grid
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false; // Ẩn cột đầu tiên của row
            this.dgvNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58))))); // Màu nền cell
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White; // Màu chữ cell
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))); // Màu khi chọn
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; // Chọn cả hàng
            this.dgvNhanVien.Size = new System.Drawing.Size(950, 550); // Ước tính kích thước
            this.dgvNhanVien.TabIndex = 0;

            //
            // colMaNV
            //
            this.colMaNV.DataPropertyName = "MaNV"; // Tên thuộc tính trong Model
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            //
            // colHoTen
            //
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và Tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            //
            // colGioiTinh
            //
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            //
            // colNgaySinh
            //
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            //
            // colPhongBan
            //
            this.colPhongBan.DataPropertyName = "PhongBan";
            this.colPhongBan.HeaderText = "Phòng ban";
            this.colPhongBan.Name = "colPhongBan";
            this.colPhongBan.ReadOnly = true;
            //
            // colChucVu
            //
            this.colChucVu.DataPropertyName = "ChucVu";
            this.colChucVu.HeaderText = "Chức vụ";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.ReadOnly = true;
            //
            // colDienThoai
            //
            this.colDienThoai.DataPropertyName = "DienThoai";
            this.colDienThoai.HeaderText = "Điện thoại";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.ReadOnly = true;
            //
            // colEmail
            //
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;

            //
            // pnlFooter (Panel chân trang)
            //
            this.pnlFooter.Controls.Add(this.btnDong);
            this.pnlFooter.Controls.Add(this.btnMacDinh);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 550); // Dưới DataGridView
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(950, 50);
            this.pnlFooter.TabIndex = 1;
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38))))); // Màu nền footer
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(10);
            //
            // btnDong
            //
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))); // Màu xanh dương
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(820, 10); // Vị trí ước tính
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            //
            // btnMacDinh
            //
            this.btnMacDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMacDinh.FlatAppearance.BorderSize = 0;
            this.btnMacDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMacDinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMacDinh.ForeColor = System.Drawing.Color.White;
            this.btnMacDinh.Location = new System.Drawing.Point(710, 10); // Vị trí ước tính
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(100, 30);
            this.btnMacDinh.TabIndex = 0;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = false;

            //
            // pnlToolbar (Thanh công cụ trên cùng)
            //
            this.pnlToolbar.Controls.Add(this.btnXoa);
            this.pnlToolbar.Controls.Add(this.btnDoLuong);
            this.pnlToolbar.Controls.Add(this.btnThietLap);
            this.pnlToolbar.Controls.Add(this.btnDiChuyen);
            this.pnlToolbar.Controls.Add(this.btnSua);
            this.pnlToolbar.Controls.Add(this.btnCapLai);
            this.pnlToolbar.Controls.Add(this.btnThem);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 50); // Dưới label title
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1200, 50);
            this.pnlToolbar.TabIndex = 1;
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38))))); // Màu nền toolbar
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0); // Padding cho các nút

            //
            // btnThem (Nút Thêm)
            //
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            // TODO: Thêm hình ảnh icon cho nút Thêm (ví dụ: Resources.AddIcon)
            // this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(10, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "  Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;

            //
            // btnCapLai (Nút Cấp lại)
            //
            this.btnCapLai.BackColor = System.Drawing.Color.Transparent;
            this.btnCapLai.FlatAppearance.BorderSize = 0;
            this.btnCapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapLai.ForeColor = System.Drawing.Color.White;
            // TODO: Thêm hình ảnh icon cho nút Cấp lại
            this.btnCapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapLai.Location = new System.Drawing.Point(115, 5);
            this.btnCapLai.Name = "btnCapLai";
            this.btnCapLai.Size = new System.Drawing.Size(100, 40);
            this.btnCapLai.TabIndex = 1;
            this.btnCapLai.Text = "  Cấp lại";
            this.btnCapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapLai.UseVisualStyleBackColor = false;

            //
            // btnSua (Nút Sửa)
            //
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            // TODO: Thêm hình ảnh icon cho nút Sửa
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(220, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "  Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;

            //
            // btnDiChuyen (Nút Di chuyển)
            //
            this.btnDiChuyen.BackColor = System.Drawing.Color.Transparent;
            this.btnDiChuyen.FlatAppearance.BorderSize = 0;
            this.btnDiChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiChuyen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiChuyen.ForeColor = System.Drawing.Color.White;
            // TODO: Thêm hình ảnh icon cho nút Di chuyển
            this.btnDiChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiChuyen.Location = new System.Drawing.Point(325, 5);
            this.btnDiChuyen.Name = "btnDiChuyen";
            this.btnDiChuyen.Size = new System.Drawing.Size(120, 40);
            this.btnDiChuyen.TabIndex = 3;
            this.btnDiChuyen.Text = "  Di chuyển";
            this.btnDiChuyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiChuyen.UseVisualStyleBackColor = false;

            //
            // btnThietLap (Nút Thiết lập)
            //
            this.btnThietLap.BackColor = System.Drawing.Color.Transparent;
            this.btnThietLap.FlatAppearance.BorderSize = 0;
            this.btnThietLap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThietLap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietLap.ForeColor = System.Drawing.Color.White;
            // TODO: Thêm hình ảnh icon cho nút Thiết lập
            this.btnThietLap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietLap.Location = new System.Drawing.Point(450, 5);
            this.btnThietLap.Name = "btnThietLap";
            this.btnThietLap.Size = new System.Drawing.Size(100, 40);
            this.btnThietLap.TabIndex = 4;
            this.btnThietLap.Text = "  Thiết lập";
            this.btnThietLap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThietLap.UseVisualStyleBackColor = false;

            //
            // btnDoLuong (Nút Đo lường)
            //
            this.btnDoLuong.BackColor = System.Drawing.Color.Transparent;
            this.btnDoLuong.FlatAppearance.BorderSize = 0;
            this.btnDoLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoLuong.ForeColor = System.Drawing.Color.White;
            // TODO: Thêm hình ảnh icon cho nút Đo lường
            this.btnDoLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoLuong.Location = new System.Drawing.Point(555, 5);
            this.btnDoLuong.Name = "btnDoLuong";
            this.btnDoLuong.Size = new System.Drawing.Size(100, 40);
            this.btnDoLuong.TabIndex = 5;
            this.btnDoLuong.Text = "  Đo lường";
            this.btnDoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoLuong.UseVisualStyleBackColor = false;

            //
            // btnXoa (Nút Xóa)
            //
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            // TODO: Thêm hình ảnh icon cho nút Xóa
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(660, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "  Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;

            //
            // lblTitle (Tiêu đề Form)
            //
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 50);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Quản Lý Nhân Viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48))))); // Màu nền title bar

            //
            // Quanlinhanvien (Main Form)
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700); // Kích thước form lớn hơn
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.lblTitle);
            this.Text = "Quản lý nhân viên";
            this.MinimumSize = new System.Drawing.Size(900, 600); // Đặt kích thước tối thiểu
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48))))); // Màu nền của form

            // Hoàn tất SuspendLayout
            this.pnlMain.ResumeLayout(false);
            this.pnlLeftSidebar.ResumeLayout(false);
            this.pnlThemeSettings.ResumeLayout(false);
            this.pnlThemeSettings.PerformLayout();
            this.pnlReport.ResumeLayout(false);
            this.pnlReport.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Khai báo các Controls đã thêm vào form
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLeftSidebar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapLai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDiChuyen;
        private System.Windows.Forms.Button btnThietLap;
        private System.Windows.Forms.Button btnDoLuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtSearchFilter;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkInactive;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Panel pnlThemeSettings;
        private System.Windows.Forms.FlowLayoutPanel flowPnlColors;
        private System.Windows.Forms.Label lblThemeSettings;

        // Khai báo cột DataGridView
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}