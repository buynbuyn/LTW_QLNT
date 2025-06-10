namespace QLNT
{
    partial class ThemNhanVien
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
        /// the really good good contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // Khai báo các Controls
            this.grpThongTinCaNhan = new System.Windows.Forms.GroupBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoKhac = new System.Windows.Forms.RadioButton();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();

            this.grpThongTinCongViec = new System.Windows.Forms.GroupBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.lblTrangThaiLamViec = new System.Windows.Forms.Label();
            this.cboTrangThaiLamViec = new System.Windows.Forms.ComboBox();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();

            this.grpThongTinKhac = new System.Windows.Forms.GroupBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblTrinhDoHocVan = new System.Windows.Forms.Label();
            this.txtTrinhDoHocVan = new System.Windows.Forms.TextBox(); // Hoặc ComboBox
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblNgayCap = new System.Windows.Forms.Label();
            this.dtpNgayCapCCCD = new System.Windows.Forms.DateTimePicker();
            this.lblNoiCap = new System.Windows.Forms.Label();
            this.txtNoiCapCCCD = new System.Windows.Forms.TextBox();


            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button(); // Tùy chọn

            //
            // ThemNhanVien
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 680); // Kích thước form lớn hơn để chứa nhiều thông tin
            this.Text = "Thêm Nhân Viên Mới";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Mở form ở giữa màn hình
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Font mặc định

            // Thêm tất cả các control vào form
            this.Controls.Add(this.grpThongTinCaNhan);
            this.Controls.Add(this.grpThongTinCongViec);
            this.Controls.Add(this.grpThongTinKhac);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnReset);

            //
            // grpThongTinCaNhan
            //
            this.grpThongTinCaNhan.Controls.Add(this.btnChonAnh);
            this.grpThongTinCaNhan.Controls.Add(this.picAnhDaiDien);
            this.grpThongTinCaNhan.Controls.Add(this.lblMaNhanVien);
            this.grpThongTinCaNhan.Controls.Add(this.txtMaNhanVien);
            this.grpThongTinCaNhan.Controls.Add(this.lblHoTen);
            this.grpThongTinCaNhan.Controls.Add(this.txtHoTen);
            this.grpThongTinCaNhan.Controls.Add(this.lblNgaySinh);
            this.grpThongTinCaNhan.Controls.Add(this.dtpNgaySinh);
            this.grpThongTinCaNhan.Controls.Add(this.lblGioiTinh);
            this.grpThongTinCaNhan.Controls.Add(this.rdoNam);
            this.grpThongTinCaNhan.Controls.Add(this.rdoNu);
            this.grpThongTinCaNhan.Controls.Add(this.rdoKhac);
            this.grpThongTinCaNhan.Controls.Add(this.lblSoDienThoai);
            this.grpThongTinCaNhan.Controls.Add(this.txtSoDienThoai);
            this.grpThongTinCaNhan.Controls.Add(this.lblEmail);
            this.grpThongTinCaNhan.Controls.Add(this.txtEmail);
            this.grpThongTinCaNhan.Controls.Add(this.lblDiaChi);
            this.grpThongTinCaNhan.Controls.Add(this.txtDiaChi);
            this.grpThongTinCaNhan.Location = new System.Drawing.Point(20, 20);
            this.grpThongTinCaNhan.Name = "grpThongTinCaNhan";
            this.grpThongTinCaNhan.Size = new System.Drawing.Size(900, 250);
            this.grpThongTinCaNhan.TabIndex = 0;
            this.grpThongTinCaNhan.TabStop = false;
            this.grpThongTinCaNhan.Text = "Thông tin cá nhân";

            //
            // picAnhDaiDien
            //
            this.picAnhDaiDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhDaiDien.Location = new System.Drawing.Point(740, 30);
            this.picAnhDaiDien.Name = "picAnhDaiDien";
            this.picAnhDaiDien.Size = new System.Drawing.Size(120, 150);
            this.picAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhDaiDien.TabIndex = 0;
            this.picAnhDaiDien.TabStop = false;
            //
            // btnChonAnh
            //
            this.btnChonAnh.Location = new System.Drawing.Point(740, 190);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(120, 30);
            this.btnChonAnh.TabIndex = 1;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;

            //
            // lblMaNhanVien
            //
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(30, 30);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(84, 20);
            this.lblMaNhanVien.TabIndex = 2;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            //
            // txtMaNhanVien
            //
            this.txtMaNhanVien.Location = new System.Drawing.Point(140, 30);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(200, 27);
            this.txtMaNhanVien.TabIndex = 3;
            this.txtMaNhanVien.ReadOnly = true; // Thường là tự động tạo
            this.txtMaNhanVien.BackColor = System.Drawing.SystemColors.Info; // Màu nền để biết là chỉ đọc

            //
            // lblHoTen
            //
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 70);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(73, 20);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ và tên:";
            //
            // txtHoTen
            //
            this.txtHoTen.Location = new System.Drawing.Point(140, 70);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 27);
            this.txtHoTen.TabIndex = 5;

            //
            // lblNgaySinh
            //
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(30, 110);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(77, 20);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh:";
            //
            // dtpNgaySinh
            //
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(140, 110);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 27);
            this.dtpNgaySinh.TabIndex = 7;

            //
            // lblGioiTinh
            //
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(30, 150);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(68, 20);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới tính:";
            //
            // rdoNam
            //
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(140, 150);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(62, 24);
            this.rdoNam.TabIndex = 9;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            //
            // rdoNu
            //
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(200, 150);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(49, 24);
            this.rdoNu.TabIndex = 10;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            //
            // rdoKhac
            //
            this.rdoKhac.AutoSize = true;
            this.rdoKhac.Location = new System.Drawing.Point(250, 150);
            this.rdoKhac.Name = "rdoKhac";
            this.rdoKhac.Size = new System.Drawing.Size(63, 24);
            this.rdoKhac.TabIndex = 11;
            this.rdoKhac.TabStop = true;
            this.rdoKhac.Text = "Khác";
            this.rdoKhac.UseVisualStyleBackColor = true;

            //
            // lblSoDienThoai
            //
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(380, 30);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(97, 20);
            this.lblSoDienThoai.TabIndex = 12;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            //
            // txtSoDienThoai
            //
            this.txtSoDienThoai.Location = new System.Drawing.Point(490, 30);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 27);
            this.txtSoDienThoai.TabIndex = 13;

            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(380, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(490, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 27);
            this.txtEmail.TabIndex = 15;

            //
            // lblDiaChi
            //
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(380, 110);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(58, 20);
            this.lblDiaChi.TabIndex = 16;
            this.lblDiaChi.Text = "Địa chỉ:";
            //
            // txtDiaChi
            //
            this.txtDiaChi.Location = new System.Drawing.Point(490, 110);
            this.txtDiaChi.Multiline = true; // Cho phép nhiều dòng
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 60);
            this.txtDiaChi.TabIndex = 17;

            //
            // grpThongTinCongViec
            //
            this.grpThongTinCongViec.Controls.Add(this.lblChucVu);
            this.grpThongTinCongViec.Controls.Add(this.cboChucVu);
            this.grpThongTinCongViec.Controls.Add(this.lblPhongBan);
            this.grpThongTinCongViec.Controls.Add(this.cboPhongBan);
            this.grpThongTinCongViec.Controls.Add(this.lblNgayVaoLam);
            this.grpThongTinCongViec.Controls.Add(this.dtpNgayVaoLam);
            this.grpThongTinCongViec.Controls.Add(this.lblTrangThaiLamViec);
            this.grpThongTinCongViec.Controls.Add(this.cboTrangThaiLamViec);
            this.grpThongTinCongViec.Controls.Add(this.lblLuongCoBan);
            this.grpThongTinCongViec.Controls.Add(this.txtLuongCoBan);
            this.grpThongTinCongViec.Location = new System.Drawing.Point(20, 290);
            this.grpThongTinCongViec.Name = "grpThongTinCongViec";
            this.grpThongTinCongViec.Size = new System.Drawing.Size(900, 150);
            this.grpThongTinCongViec.TabIndex = 1;
            this.grpThongTinCongViec.TabStop = false;
            this.grpThongTinCongViec.Text = "Thông tin công việc";

            //
            // lblChucVu
            //
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(30, 30);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(65, 20);
            this.lblChucVu.TabIndex = 0;
            this.lblChucVu.Text = "Chức vụ:";
            //
            // cboChucVu
            //
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(140, 30);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(200, 28);
            this.cboChucVu.TabIndex = 1;
            // Thêm các item ví dụ (có thể load từ CSDL)
            this.cboChucVu.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên",
            "Thực tập sinh",
            "Trưởng phòng"});

            //
            // lblPhongBan
            //
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location = new System.Drawing.Point(30, 70);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(81, 20);
            this.lblPhongBan.TabIndex = 2;
            this.lblPhongBan.Text = "Phòng ban:";
            //
            // cboPhongBan
            //
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(140, 70);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(200, 28);
            this.cboPhongBan.TabIndex = 3;
            // Thêm các item ví dụ (có thể load từ CSDL)
            this.cboPhongBan.Items.AddRange(new object[] {
            "Kế toán",
            "Kinh doanh",
            "Hành chính",
            "Kỹ thuật"});

            //
            // lblNgayVaoLam
            //
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Location = new System.Drawing.Point(380, 30);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(99, 20);
            this.lblNgayVaoLam.TabIndex = 4;
            this.lblNgayVaoLam.Text = "Ngày vào làm:";
            //
            // dtpNgayVaoLam
            //
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(490, 30);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayVaoLam.TabIndex = 5;

            //
            // lblTrangThaiLamViec
            //
            this.lblTrangThaiLamViec.AutoSize = true;
            this.lblTrangThaiLamViec.Location = new System.Drawing.Point(380, 70);
            this.lblTrangThaiLamViec.Name = "lblTrangThaiLamViec";
            this.lblTrangThaiLamViec.Size = new System.Drawing.Size(129, 20);
            this.lblTrangThaiLamViec.TabIndex = 6;
            this.lblTrangThaiLamViec.Text = "Trạng thái làm việc:";
            //
            // cboTrangThaiLamViec
            //
            this.cboTrangThaiLamViec.FormattingEnabled = true;
            this.cboTrangThaiLamViec.Location = new System.Drawing.Point(520, 70);
            this.cboTrangThaiLamViec.Name = "cboTrangThaiLamViec";
            this.cboTrangThaiLamViec.Size = new System.Drawing.Size(170, 28);
            this.cboTrangThaiLamViec.TabIndex = 7;
            this.cboTrangThaiLamViec.Items.AddRange(new object[] {
            "Đang làm việc",
            "Nghỉ việc",
            "Nghỉ phép"});
            this.cboTrangThaiLamViec.SelectedItem = "Đang làm việc"; // Giá trị mặc định

            //
            // lblLuongCoBan
            //
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.Location = new System.Drawing.Point(30, 110);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(100, 20);
            this.lblLuongCoBan.TabIndex = 8;
            this.lblLuongCoBan.Text = "Lương cơ bản:";
            //
            // txtLuongCoBan
            //
            this.txtLuongCoBan.Location = new System.Drawing.Point(140, 110);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(200, 27);
            this.txtLuongCoBan.TabIndex = 9;
            this.txtLuongCoBan.Text = "0"; // Giá trị mặc định
            this.txtLuongCoBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right; // Căn phải
            // Thêm xử lý sự kiện để chỉ cho phép nhập số
     

            //
            // grpThongTinKhac
            //
            this.grpThongTinKhac.Controls.Add(this.lblGhiChu);
            this.grpThongTinKhac.Controls.Add(this.txtGhiChu);
            this.grpThongTinKhac.Controls.Add(this.lblTrinhDoHocVan);
            this.grpThongTinKhac.Controls.Add(this.txtTrinhDoHocVan);
            this.grpThongTinKhac.Controls.Add(this.lblCCCD);
            this.grpThongTinKhac.Controls.Add(this.txtCCCD);
            this.grpThongTinKhac.Controls.Add(this.lblNgayCap);
            this.grpThongTinKhac.Controls.Add(this.dtpNgayCapCCCD);
            this.grpThongTinKhac.Controls.Add(this.lblNoiCap);
            this.grpThongTinKhac.Controls.Add(this.txtNoiCapCCCD);
            this.grpThongTinKhac.Location = new System.Drawing.Point(20, 460);
            this.grpThongTinKhac.Name = "grpThongTinKhac";
            this.grpThongTinKhac.Size = new System.Drawing.Size(900, 150);
            this.grpThongTinKhac.TabIndex = 2;
            this.grpThongTinKhac.TabStop = false;
            this.grpThongTinKhac.Text = "Thông tin khác";

            //
            // lblGhiChu
            //
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(30, 30);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(63, 20);
            this.lblGhiChu.TabIndex = 0;
            this.lblGhiChu.Text = "Ghi chú:";
            //
            // txtGhiChu
            //
            this.txtGhiChu.Location = new System.Drawing.Point(140, 30);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 80);
            this.txtGhiChu.TabIndex = 1;

            //
            // lblTrinhDoHocVan
            //
            this.lblTrinhDoHocVan.AutoSize = true;
            this.lblTrinhDoHocVan.Location = new System.Drawing.Point(380, 30);
            this.lblTrinhDoHocVan.Name = "lblTrinhDoHocVan";
            this.lblTrinhDoHocVan.Size = new System.Drawing.Size(122, 20);
            this.lblTrinhDoHocVan.TabIndex = 2;
            this.lblTrinhDoHocVan.Text = "Trình độ học vấn:";
            //
            // txtTrinhDoHocVan
            //
            this.txtTrinhDoHocVan.Location = new System.Drawing.Point(520, 30);
            this.txtTrinhDoHocVan.Name = "txtTrinhDoHocVan";
            this.txtTrinhDoHocVan.Size = new System.Drawing.Size(200, 27);
            this.txtTrinhDoHocVan.TabIndex = 3;

            //
            // lblCCCD
            //
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(380, 70);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(53, 20);
            this.lblCCCD.TabIndex = 4;
            this.lblCCCD.Text = "CCCD:";
            //
            // txtCCCD
            //
            this.txtCCCD.Location = new System.Drawing.Point(520, 70);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(200, 27);
            this.txtCCCD.TabIndex = 5;

            //
            // lblNgayCap
            //
            this.lblNgayCap.AutoSize = true;
            this.lblNgayCap.Location = new System.Drawing.Point(380, 110);
            this.lblNgayCap.Name = "lblNgayCap";
            this.lblNgayCap.Size = new System.Drawing.Size(73, 20);
            this.lblNgayCap.TabIndex = 6;
            this.lblNgayCap.Text = "Ngày cấp:";
            //
            // dtpNgayCapCCCD
            //
            this.dtpNgayCapCCCD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCapCCCD.Location = new System.Drawing.Point(520, 110);
            this.dtpNgayCapCCCD.Name = "dtpNgayCapCCCD";
            this.dtpNgayCapCCCD.Size = new System.Drawing.Size(100, 27);
            this.dtpNgayCapCCCD.TabIndex = 7;

            //
            // lblNoiCap
            //
            this.lblNoiCap.AutoSize = true;
            this.lblNoiCap.Location = new System.Drawing.Point(630, 110);
            this.lblNoiCap.Name = "lblNoiCap";
            this.lblNoiCap.Size = new System.Drawing.Size(61, 20);
            this.lblNoiCap.TabIndex = 8;
            this.lblNoiCap.Text = "Nơi cấp:";
            //
            // txtNoiCapCCCD
            //
            this.txtNoiCapCCCD.Location = new System.Drawing.Point(690, 110);
            this.txtNoiCapCCCD.Name = "txtNoiCapCCCD";
            this.txtNoiCapCCCD.Size = new System.Drawing.Size(150, 27);
            this.txtNoiCapCCCD.TabIndex = 9;

            //
            // btnLuu
            //
            this.btnLuu.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(620, 630);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 35);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;

            //
            // btnHuy
            //
            this.btnHuy.BackColor = System.Drawing.Color.LightGray;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(720, 630);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 35);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;

            //
            // btnReset
            //
            this.btnReset.BackColor = System.Drawing.Color.Orange;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(820, 630);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 35);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;

            // Để các controls tự động thay đổi kích thước theo form
            this.grpThongTinCaNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinKhac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));

            // Thêm các controls đã khai báo vào GroupBox (đây là phần bạn sẽ tự thêm vào)
            // Hoặc bạn có thể kéo thả trong Designer và Visual Studio sẽ tự tạo code này
            // Ví dụ:
            // this.grpThongTinCaNhan.Controls.Add(this.lblMaNhanVien);
            // this.grpThongTinCaNhan.Controls.Add(this.txtMaNhanVien);
            // ... và cứ thế cho tất cả các control con của từng GroupBox.

            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).EndInit();
            this.grpThongTinCaNhan.ResumeLayout(false);
            this.grpThongTinCaNhan.PerformLayout();
            this.grpThongTinCongViec.ResumeLayout(false);
            this.grpThongTinCongViec.PerformLayout();
            this.grpThongTinKhac.ResumeLayout(false);
            this.grpThongTinKhac.PerformLayout();
            this.ResumeLayout(false);
        }

        // Khai báo các biến Control (Đây là phần bạn sẽ tự thêm vào trong class ThemNhanVien)
        // Hoặc để Designer tự tạo cho bạn
        private System.Windows.Forms.GroupBox grpThongTinCaNhan;
        private System.Windows.Forms.PictureBox picAnhDaiDien;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoKhac;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;

        private System.Windows.Forms.GroupBox grpThongTinCongViec;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.Label lblTrangThaiLamViec;
        private System.Windows.Forms.ComboBox cboTrangThaiLamViec;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.TextBox txtLuongCoBan;

        private System.Windows.Forms.GroupBox grpThongTinKhac;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblTrinhDoHocVan;
        private System.Windows.Forms.TextBox txtTrinhDoHocVan;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblNgayCap;
        private System.Windows.Forms.DateTimePicker dtpNgayCapCCCD;
        private System.Windows.Forms.Label lblNoiCap;
        private System.Windows.Forms.TextBox txtNoiCapCCCD;

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnReset;


        #endregion
    }
}