namespace QLNT
{
    partial class ThemKhachHangForm
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
            label1 = new Label();
            SuspendLayout();
            // 
            // cbGioiTinh_Them
            // 
            cbGioiTinh_Them.FormattingEnabled = true;
            cbGioiTinh_Them.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh_Them.Location = new Point(64, 152);
            cbGioiTinh_Them.Name = "cbGioiTinh_Them";
            cbGioiTinh_Them.Size = new Size(151, 28);
            cbGioiTinh_Them.TabIndex = 22;
            cbGioiTinh_Them.Text = "Nam/Nữ";
            // 
            // lblGioiTinh_Them
            // 
            lblGioiTinh_Them.AutoSize = true;
            lblGioiTinh_Them.Location = new Point(64, 129);
            lblGioiTinh_Them.Name = "lblGioiTinh_Them";
            lblGioiTinh_Them.Size = new Size(65, 20);
            lblGioiTinh_Them.TabIndex = 21;
            lblGioiTinh_Them.Text = "Giới tính";
            // 
            // txtEmail_Them
            // 
            txtEmail_Them.Location = new Point(64, 216);
            txtEmail_Them.Name = "txtEmail_Them";
            txtEmail_Them.Size = new Size(322, 27);
            txtEmail_Them.TabIndex = 20;
            // 
            // lblEmail_Them
            // 
            lblEmail_Them.AutoSize = true;
            lblEmail_Them.Location = new Point(64, 193);
            lblEmail_Them.Name = "lblEmail_Them";
            lblEmail_Them.Size = new Size(46, 20);
            lblEmail_Them.TabIndex = 19;
            lblEmail_Them.Text = "Email";
            // 
            // btnThemKH
            // 
            btnThemKH.Location = new Point(153, 388);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(124, 29);
            btnThemKH.TabIndex = 13;
            btnThemKH.Text = "Thêm";
            btnThemKH.UseVisualStyleBackColor = true;
            btnThemKH.Click += btnLuu_Click;
            // 
            // txtSDT_Them
            // 
            txtSDT_Them.Location = new Point(64, 269);
            txtSDT_Them.Name = "txtSDT_Them";
            txtSDT_Them.Size = new Size(322, 27);
            txtSDT_Them.TabIndex = 18;
            // 
            // lblSDT_Them
            // 
            lblSDT_Them.AutoSize = true;
            lblSDT_Them.Location = new Point(64, 246);
            lblSDT_Them.Name = "lblSDT_Them";
            lblSDT_Them.Size = new Size(97, 20);
            lblSDT_Them.TabIndex = 17;
            lblSDT_Them.Text = "Số điện thoại";
            // 
            // txtDiaChi_Them
            // 
            txtDiaChi_Them.Location = new Point(62, 333);
            txtDiaChi_Them.Name = "txtDiaChi_Them";
            txtDiaChi_Them.Size = new Size(322, 27);
            txtDiaChi_Them.TabIndex = 16;
            // 
            // lblDiaChi_Them
            // 
            lblDiaChi_Them.AutoSize = true;
            lblDiaChi_Them.Location = new Point(66, 310);
            lblDiaChi_Them.Name = "lblDiaChi_Them";
            lblDiaChi_Them.Size = new Size(55, 20);
            lblDiaChi_Them.TabIndex = 15;
            lblDiaChi_Them.Text = "Địa chỉ";
            // 
            // txtTen_Them
            // 
            txtTen_Them.Location = new Point(64, 93);
            txtTen_Them.Name = "txtTen_Them";
            txtTen_Them.Size = new Size(322, 27);
            txtTen_Them.TabIndex = 14;
            txtTen_Them.TextChanged += txtTen_Them_TextChanged;
            // 
            // lblTen_Them
            // 
            lblTen_Them.AutoSize = true;
            lblTen_Them.Location = new Point(64, 70);
            lblTen_Them.Name = "lblTen_Them";
            lblTen_Them.Size = new Size(111, 20);
            lblTen_Them.TabIndex = 12;
            lblTen_Them.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.Location = new Point(94, 26);
            label1.Name = "label1";
            label1.Size = new Size(259, 30);
            label1.TabIndex = 24;
            label1.Text = "THÊM KHÁCH HÀNG";
            // 
            // ThemKhachHangForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 450);
            Controls.Add(label1);
            Controls.Add(cbGioiTinh_Them);
            Controls.Add(lblGioiTinh_Them);
            Controls.Add(txtEmail_Them);
            Controls.Add(lblEmail_Them);
            Controls.Add(btnThemKH);
            Controls.Add(txtSDT_Them);
            Controls.Add(lblSDT_Them);
            Controls.Add(txtDiaChi_Them);
            Controls.Add(lblDiaChi_Them);
            Controls.Add(txtTen_Them);
            Controls.Add(lblTen_Them);
            Name = "ThemKhachHangForm";
            Text = "ThemKhachHangForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbGioiTinh_Them;
        private Label lblGioiTinh_Them;
        private TextBox txtEmail_Them;
        private Label lblEmail_Them;
        private Button btnThemKH;
        private TextBox txtSDT_Them;
        private Label lblSDT_Them;
        private TextBox txtDiaChi_Them;
        private Label lblDiaChi_Them;
        private TextBox txtTen_Them;
        private Label lblTen_Them;
        private Label label1;
    }
}