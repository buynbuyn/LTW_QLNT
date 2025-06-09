namespace QLNT
{
    partial class SuaKhachHangForm
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
            cbGioiTinh_Sua = new ComboBox();
            lblGioiTinh_Them = new Label();
            txtEmail_Sua = new TextBox();
            lblEmail_Them = new Label();
            btnThemKH = new Button();
            txtSDT_Sua = new TextBox();
            lblSDT_Them = new Label();
            txtDiaChi_Sua = new TextBox();
            lblDiaChi_Them = new Label();
            txtTen_Sua = new TextBox();
            lblTen_Them = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbGioiTinh_Sua
            // 
            cbGioiTinh_Sua.FormattingEnabled = true;
            cbGioiTinh_Sua.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh_Sua.Location = new Point(68, 141);
            cbGioiTinh_Sua.Name = "cbGioiTinh_Sua";
            cbGioiTinh_Sua.Size = new Size(111, 28);
            cbGioiTinh_Sua.TabIndex = 22;
            cbGioiTinh_Sua.Text = "Nam/Nữ";
            // 
            // lblGioiTinh_Them
            // 
            lblGioiTinh_Them.AutoSize = true;
            lblGioiTinh_Them.Location = new Point(68, 118);
            lblGioiTinh_Them.Name = "lblGioiTinh_Them";
            lblGioiTinh_Them.Size = new Size(65, 20);
            lblGioiTinh_Them.TabIndex = 21;
            lblGioiTinh_Them.Text = "Giới tính";
            // 
            // txtEmail_Sua
            // 
            txtEmail_Sua.Location = new Point(70, 205);
            txtEmail_Sua.Name = "txtEmail_Sua";
            txtEmail_Sua.Size = new Size(295, 27);
            txtEmail_Sua.TabIndex = 20;
            // 
            // lblEmail_Them
            // 
            lblEmail_Them.AutoSize = true;
            lblEmail_Them.Location = new Point(68, 182);
            lblEmail_Them.Name = "lblEmail_Them";
            lblEmail_Them.Size = new Size(46, 20);
            lblEmail_Them.TabIndex = 19;
            lblEmail_Them.Text = "Email";
            // 
            // btnThemKH
            // 
            btnThemKH.Location = new Point(153, 377);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(124, 29);
            btnThemKH.TabIndex = 13;
            btnThemKH.Text = "Thêm";
            btnThemKH.UseVisualStyleBackColor = true;
            btnThemKH.Click += btnLuu_Click;
            // 
            // txtSDT_Sua
            // 
            txtSDT_Sua.Location = new Point(70, 258);
            txtSDT_Sua.Name = "txtSDT_Sua";
            txtSDT_Sua.Size = new Size(295, 27);
            txtSDT_Sua.TabIndex = 18;
            // 
            // lblSDT_Them
            // 
            lblSDT_Them.AutoSize = true;
            lblSDT_Them.Location = new Point(68, 235);
            lblSDT_Them.Name = "lblSDT_Them";
            lblSDT_Them.Size = new Size(97, 20);
            lblSDT_Them.TabIndex = 17;
            lblSDT_Them.Text = "Số điện thoại";
            // 
            // txtDiaChi_Sua
            // 
            txtDiaChi_Sua.Location = new Point(68, 322);
            txtDiaChi_Sua.Name = "txtDiaChi_Sua";
            txtDiaChi_Sua.Size = new Size(295, 27);
            txtDiaChi_Sua.TabIndex = 16;
            // 
            // lblDiaChi_Them
            // 
            lblDiaChi_Them.AutoSize = true;
            lblDiaChi_Them.Location = new Point(70, 299);
            lblDiaChi_Them.Name = "lblDiaChi_Them";
            lblDiaChi_Them.Size = new Size(55, 20);
            lblDiaChi_Them.TabIndex = 15;
            lblDiaChi_Them.Text = "Địa chỉ";
            // 
            // txtTen_Sua
            // 
            txtTen_Sua.Location = new Point(70, 88);
            txtTen_Sua.Name = "txtTen_Sua";
            txtTen_Sua.Size = new Size(295, 27);
            txtTen_Sua.TabIndex = 14;
            // 
            // lblTen_Them
            // 
            lblTen_Them.AutoSize = true;
            lblTen_Them.Location = new Point(68, 65);
            lblTen_Them.Name = "lblTen_Them";
            lblTen_Them.Size = new Size(111, 20);
            lblTen_Them.TabIndex = 12;
            lblTen_Them.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.Location = new Point(105, 21);
            label1.Name = "label1";
            label1.Size = new Size(235, 30);
            label1.TabIndex = 23;
            label1.Text = "SỬA KHÁCH HÀNG";
            // 
            // SuaKhachHangForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 425);
            Controls.Add(label1);
            Controls.Add(cbGioiTinh_Sua);
            Controls.Add(lblGioiTinh_Them);
            Controls.Add(txtEmail_Sua);
            Controls.Add(lblEmail_Them);
            Controls.Add(btnThemKH);
            Controls.Add(txtSDT_Sua);
            Controls.Add(lblSDT_Them);
            Controls.Add(txtDiaChi_Sua);
            Controls.Add(lblDiaChi_Them);
            Controls.Add(txtTen_Sua);
            Controls.Add(lblTen_Them);
            Name = "SuaKhachHangForm";
            Text = "SuaKhachHangForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbGioiTinh_Sua;
        private Label lblGioiTinh_Them;
        private TextBox txtEmail_Sua;
        private Label lblEmail_Them;
        private Button btnThemKH;
        private TextBox txtSDT_Sua;
        private Label lblSDT_Them;
        private TextBox txtDiaChi_Sua;
        private Label lblDiaChi_Them;
        private TextBox txtTen_Sua;
        private Label lblTen_Them;
        private Label label1;
    }
}