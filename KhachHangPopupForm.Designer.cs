namespace QLNT
{
    partial class KhachHangPopupForm
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
            tabKhachHang = new TabControl();
            tabPageThem = new TabPage();
            cbGioiTinh_Them = new ComboBox();
            lblGioiTinh_Them = new Label();
            txtEmail_Them = new TextBox();
            lblEmail_Them = new Label();
            btnThemKH = new Button();
            txtSDT_Them = new TextBox();
            lblSDT_Them = new Label();
            txtDiaChi_Them = new TextBox();
            lblDiaChi_Them = new Label();
            txtTen_Them = new TextBox();
            lblTen_Them = new Label();
            tabPageSua = new TabPage();
            cbGioiTinh_Sua = new ComboBox();
            label1 = new Label();
            txtEmail_Sua = new TextBox();
            label2 = new Label();
            btnCapNhatKH = new Button();
            txtSDT_Sua = new TextBox();
            label3 = new Label();
            txtDiaChi_Sua = new TextBox();
            label4 = new Label();
            txtTen_Sua = new TextBox();
            label5 = new Label();
            tabKhachHang.SuspendLayout();
            tabPageThem.SuspendLayout();
            tabPageSua.SuspendLayout();
            SuspendLayout();
            // 
            // tabKhachHang
            // 
            tabKhachHang.Controls.Add(tabPageThem);
            tabKhachHang.Controls.Add(tabPageSua);
            tabKhachHang.Dock = DockStyle.Fill;
            tabKhachHang.Location = new Point(0, 0);
            tabKhachHang.Name = "tabKhachHang";
            tabKhachHang.SelectedIndex = 0;
            tabKhachHang.Size = new Size(681, 609);
            tabKhachHang.TabIndex = 0;
            tabKhachHang.Click += btnThemKH_Click;
            // 
            // tabPageThem
            // 
            tabPageThem.Controls.Add(cbGioiTinh_Them);
            tabPageThem.Controls.Add(lblGioiTinh_Them);
            tabPageThem.Controls.Add(txtEmail_Them);
            tabPageThem.Controls.Add(lblEmail_Them);
            tabPageThem.Controls.Add(btnThemKH);
            tabPageThem.Controls.Add(txtSDT_Them);
            tabPageThem.Controls.Add(lblSDT_Them);
            tabPageThem.Controls.Add(txtDiaChi_Them);
            tabPageThem.Controls.Add(lblDiaChi_Them);
            tabPageThem.Controls.Add(txtTen_Them);
            tabPageThem.Controls.Add(lblTen_Them);
            tabPageThem.Location = new Point(4, 29);
            tabPageThem.Name = "tabPageThem";
            tabPageThem.Padding = new Padding(3);
            tabPageThem.Size = new Size(673, 576);
            tabPageThem.TabIndex = 0;
            tabPageThem.UseVisualStyleBackColor = true;
            // 
            // cbGioiTinh_Them
            // 
            cbGioiTinh_Them.FormattingEnabled = true;
            cbGioiTinh_Them.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh_Them.Location = new Point(6, 79);
            cbGioiTinh_Them.Name = "cbGioiTinh_Them";
            cbGioiTinh_Them.Size = new Size(151, 28);
            cbGioiTinh_Them.TabIndex = 11;
            cbGioiTinh_Them.Text = "Nam/Nữ";
            // 
            // lblGioiTinh_Them
            // 
            lblGioiTinh_Them.AutoSize = true;
            lblGioiTinh_Them.Location = new Point(6, 56);
            lblGioiTinh_Them.Name = "lblGioiTinh_Them";
            lblGioiTinh_Them.Size = new Size(65, 20);
            lblGioiTinh_Them.TabIndex = 10;
            lblGioiTinh_Them.Text = "Giới tính";
            // 
            // txtEmail_Them
            // 
            txtEmail_Them.Location = new Point(8, 143);
            txtEmail_Them.Name = "txtEmail_Them";
            txtEmail_Them.Size = new Size(232, 27);
            txtEmail_Them.TabIndex = 9;
            // 
            // lblEmail_Them
            // 
            lblEmail_Them.AutoSize = true;
            lblEmail_Them.Location = new Point(6, 120);
            lblEmail_Them.Name = "lblEmail_Them";
            lblEmail_Them.Size = new Size(46, 20);
            lblEmail_Them.TabIndex = 8;
            lblEmail_Them.Text = "Email";
            // 
            // btnThemKH
            // 
            btnThemKH.Location = new Point(42, 315);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(124, 29);
            btnThemKH.TabIndex = 1;
            btnThemKH.Text = "Thêm";
            btnThemKH.UseVisualStyleBackColor = true;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // txtSDT_Them
            // 
            txtSDT_Them.Location = new Point(8, 196);
            txtSDT_Them.Name = "txtSDT_Them";
            txtSDT_Them.Size = new Size(232, 27);
            txtSDT_Them.TabIndex = 7;
            // 
            // lblSDT_Them
            // 
            lblSDT_Them.AutoSize = true;
            lblSDT_Them.Location = new Point(6, 173);
            lblSDT_Them.Name = "lblSDT_Them";
            lblSDT_Them.Size = new Size(97, 20);
            lblSDT_Them.TabIndex = 6;
            lblSDT_Them.Text = "Số điện thoại";
            lblSDT_Them.Click += lblSDT_Them_Click;
            // 
            // txtDiaChi_Them
            // 
            txtDiaChi_Them.Location = new Point(6, 260);
            txtDiaChi_Them.Name = "txtDiaChi_Them";
            txtDiaChi_Them.Size = new Size(232, 27);
            txtDiaChi_Them.TabIndex = 5;
            // 
            // lblDiaChi_Them
            // 
            lblDiaChi_Them.AutoSize = true;
            lblDiaChi_Them.Location = new Point(8, 237);
            lblDiaChi_Them.Name = "lblDiaChi_Them";
            lblDiaChi_Them.Size = new Size(55, 20);
            lblDiaChi_Them.TabIndex = 4;
            lblDiaChi_Them.Text = "Địa chỉ";
            // 
            // txtTen_Them
            // 
            txtTen_Them.Location = new Point(8, 26);
            txtTen_Them.Name = "txtTen_Them";
            txtTen_Them.Size = new Size(232, 27);
            txtTen_Them.TabIndex = 1;
            // 
            // lblTen_Them
            // 
            lblTen_Them.AutoSize = true;
            lblTen_Them.Location = new Point(6, 3);
            lblTen_Them.Name = "lblTen_Them";
            lblTen_Them.Size = new Size(111, 20);
            lblTen_Them.TabIndex = 0;
            lblTen_Them.Text = "Tên khách hàng";
            // 
            // tabPageSua
            // 
            tabPageSua.Controls.Add(cbGioiTinh_Sua);
            tabPageSua.Controls.Add(label1);
            tabPageSua.Controls.Add(txtEmail_Sua);
            tabPageSua.Controls.Add(label2);
            tabPageSua.Controls.Add(btnCapNhatKH);
            tabPageSua.Controls.Add(txtSDT_Sua);
            tabPageSua.Controls.Add(label3);
            tabPageSua.Controls.Add(txtDiaChi_Sua);
            tabPageSua.Controls.Add(label4);
            tabPageSua.Controls.Add(txtTen_Sua);
            tabPageSua.Controls.Add(label5);
            tabPageSua.Location = new Point(4, 29);
            tabPageSua.Name = "tabPageSua";
            tabPageSua.Padding = new Padding(3);
            tabPageSua.Size = new Size(673, 576);
            tabPageSua.TabIndex = 1;
            tabPageSua.UseVisualStyleBackColor = true;
            // 
            // cbGioiTinh_Sua
            // 
            cbGioiTinh_Sua.FormattingEnabled = true;
            cbGioiTinh_Sua.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh_Sua.Location = new Point(18, 90);
            cbGioiTinh_Sua.Name = "cbGioiTinh_Sua";
            cbGioiTinh_Sua.Size = new Size(151, 28);
            cbGioiTinh_Sua.TabIndex = 22;
            cbGioiTinh_Sua.Text = "Nam/Nữ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 67);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 21;
            label1.Text = "Giới tính";
            // 
            // txtEmail_Sua
            // 
            txtEmail_Sua.Location = new Point(20, 154);
            txtEmail_Sua.Name = "txtEmail_Sua";
            txtEmail_Sua.Size = new Size(232, 27);
            txtEmail_Sua.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 131);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 19;
            label2.Text = "Email";
            // 
            // btnCapNhatKH
            // 
            btnCapNhatKH.Location = new Point(54, 326);
            btnCapNhatKH.Name = "btnCapNhatKH";
            btnCapNhatKH.Size = new Size(124, 29);
            btnCapNhatKH.TabIndex = 13;
            btnCapNhatKH.Text = "Cập nhật";
            btnCapNhatKH.UseVisualStyleBackColor = true;
            btnCapNhatKH.Click += btnCapNhatKH_Click;
            // 
            // txtSDT_Sua
            // 
            txtSDT_Sua.Location = new Point(20, 207);
            txtSDT_Sua.Name = "txtSDT_Sua";
            txtSDT_Sua.Size = new Size(232, 27);
            txtSDT_Sua.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 184);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 17;
            label3.Text = "Số điện thoại";
            // 
            // txtDiaChi_Sua
            // 
            txtDiaChi_Sua.Location = new Point(18, 271);
            txtDiaChi_Sua.Name = "txtDiaChi_Sua";
            txtDiaChi_Sua.Size = new Size(232, 27);
            txtDiaChi_Sua.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 248);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 15;
            label4.Text = "Địa chỉ";
            // 
            // txtTen_Sua
            // 
            txtTen_Sua.Location = new Point(20, 37);
            txtTen_Sua.Name = "txtTen_Sua";
            txtTen_Sua.Size = new Size(232, 27);
            txtTen_Sua.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 14);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 12;
            label5.Text = "Tên khách hàng";
            // 
            // KhachHangPopupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 609);
            Controls.Add(tabKhachHang);
            Name = "KhachHangPopupForm";
            Text = "KhachHangPopupForm";
            tabKhachHang.ResumeLayout(false);
            tabPageThem.ResumeLayout(false);
            tabPageThem.PerformLayout();
            tabPageSua.ResumeLayout(false);
            tabPageSua.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabKhachHang;
        private TabPage tabPageThem;
        private Label lblTen_Them;
        private TabPage tabPageSua;
        private Label lblDiaChi_Them;
        private TextBox txtTen_Them;
        private Button btnThemKH;
        private TextBox txtSDT_Them;
        private Label lblSDT_Them;
        private TextBox txtDiaChi_Them;
        private Label lblGioiTinh_Them;
        private TextBox txtEmail_Them;
        private Label lblEmail_Them;
        private ComboBox cbGioiTinh_Them;
        private ComboBox cbGioiTinh_Sua;
        private Label label1;
        private TextBox txtEmail_Sua;
        private Label label2;
        private Button btnCapNhatKH;
        private TextBox txtSDT_Sua;
        private Label label3;
        private TextBox txtDiaChi_Sua;
        private Label label4;
        private TextBox txtTen_Sua;
        private Label label5;
    }
}