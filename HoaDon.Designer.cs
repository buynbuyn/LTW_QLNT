namespace QLNT
{
    partial class Hoadon
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ThongTinThuocColumn = new DataGridViewTextBoxColumn();
            SoLuongColumn = new DataGridViewTextBoxColumn();
            DonViTinhColumn = new DataGridViewTextBoxColumn();
            ThanhTienColumn = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            cboThongTinThuoc = new ComboBox();
            btn_remove = new Button();
            label4 = new Label();
            tbSDTKH = new TextBox();
            label5 = new Label();
            cboPhuongthuc = new ComboBox();
            label6 = new Label();
            cboVoucher = new ComboBox();
            panel1 = new Panel();
            btn_huydonhang = new Button();
            btn_xuathoadon = new Button();
            tBoThanhtien = new TextBox();
            label10 = new Label();
            label9 = new Label();
            tBoTongtien = new TextBox();
            label8 = new Label();
            tBoSL = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(476, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 38);
            label1.TabIndex = 0;
            label1.Text = "Giỏ hàng của bạn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ThongTinThuocColumn, SoLuongColumn, DonViTinhColumn, ThanhTienColumn });
            dataGridView1.Location = new Point(12, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(554, 444);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ThongTinThuocColumn
            // 
            ThongTinThuocColumn.HeaderText = "Tên sản phẩm";
            ThongTinThuocColumn.MinimumWidth = 6;
            ThongTinThuocColumn.Name = "ThongTinThuocColumn";
            ThongTinThuocColumn.Width = 200;
            // 
            // SoLuongColumn
            // 
            SoLuongColumn.HeaderText = "Số lượng";
            SoLuongColumn.MinimumWidth = 6;
            SoLuongColumn.Name = "SoLuongColumn";
            SoLuongColumn.Width = 80;
            // 
            // DonViTinhColumn
            // 
            DonViTinhColumn.HeaderText = "Đơn vị tính";
            DonViTinhColumn.MinimumWidth = 6;
            DonViTinhColumn.Name = "DonViTinhColumn";
            DonViTinhColumn.Width = 100;
            // 
            // ThanhTienColumn
            // 
            ThanhTienColumn.HeaderText = "Thành tiền";
            ThanhTienColumn.MinimumWidth = 6;
            ThanhTienColumn.Name = "ThanhTienColumn";
            ThanhTienColumn.Width = 120;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 2;
            label2.Text = "Danh sách sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(590, 83);
            label3.Name = "label3";
            label3.Size = new Size(229, 28);
            label3.TabIndex = 3;
            label3.Text = "Xóa sản phẩm của bạn";
            // 
            // cboThongTinThuoc
            // 
            cboThongTinThuoc.FormattingEnabled = true;
            cboThongTinThuoc.Location = new Point(590, 114);
            cboThongTinThuoc.Name = "cboThongTinThuoc";
            cboThongTinThuoc.Size = new Size(151, 28);
            cboThongTinThuoc.TabIndex = 4;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.Red;
            btn_remove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove.ForeColor = SystemColors.ControlLightLight;
            btn_remove.Location = new Point(760, 114);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(123, 29);
            btn_remove.TabIndex = 5;
            btn_remove.Text = "Xóa sản phẩm";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click; // Sửa thành btn_remove_Click
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(590, 146);
            label4.Name = "label4";
            label4.Size = new Size(253, 28);
            label4.TabIndex = 6;
            label4.Text = "Số điện thoại khách hàng";
            label4.Click += label4_Click;
            // 
            // tbSDTKH
            // 
            tbSDTKH.Location = new Point(590, 177);
            tbSDTKH.Name = "tbSDTKH";
            tbSDTKH.Size = new Size(293, 27);
            tbSDTKH.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(590, 207);
            label5.Name = "label5";
            label5.Size = new Size(246, 28);
            label5.TabIndex = 8;
            label5.Text = "Phương thức thanh toán";
            label5.Click += label5_Click;
            // 
            // cboPhuongthuc
            // 
            cboPhuongthuc.FormattingEnabled = true;
            cboPhuongthuc.Location = new Point(590, 238);
            cboPhuongthuc.Name = "cboPhuongthuc";
            cboPhuongthuc.Size = new Size(293, 28);
            cboPhuongthuc.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(590, 269);
            label6.Name = "label6";
            label6.Size = new Size(131, 28);
            label6.TabIndex = 10;
            label6.Text = "Mã giảm giá";
            label6.Click += label6_Click;
            // 
            // cboVoucher
            // 
            cboVoucher.FormattingEnabled = true;
            cboVoucher.Location = new Point(590, 300);
            cboVoucher.Name = "cboVoucher";
            cboVoucher.Size = new Size(293, 28);
            cboVoucher.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_huydonhang);
            panel1.Controls.Add(btn_xuathoadon);
            panel1.Controls.Add(tBoThanhtien);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tBoTongtien);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tBoSL);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(593, 346);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 181);
            panel1.TabIndex = 12;
            // 
            // btn_huydonhang
            // 
            btn_huydonhang.BackColor = Color.IndianRed;
            btn_huydonhang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_huydonhang.Location = new Point(325, 99);
            btn_huydonhang.Name = "btn_huydonhang";
            btn_huydonhang.Size = new Size(158, 43);
            btn_huydonhang.TabIndex = 20;
            btn_huydonhang.Text = "Hủy";
            btn_huydonhang.UseVisualStyleBackColor = false;
            btn_huydonhang.Click += btn_huydonhang_Click; // Sửa thành btn_huydonhang_Click
            // 
            // btn_xuathoadon
            // 
            btn_xuathoadon.BackColor = Color.Lime;
            btn_xuathoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xuathoadon.Location = new Point(325, 30);
            btn_xuathoadon.Name = "btn_xuathoadon";
            btn_xuathoadon.Size = new Size(158, 43);
            btn_xuathoadon.TabIndex = 19;
            btn_xuathoadon.Text = "Xuất hóa đơn";
            btn_xuathoadon.UseVisualStyleBackColor = false;
            btn_xuathoadon.Click += btn_xuathoadon_Click; // Sửa thành btn_xuathoadon_Click
            // 
            // tBoThanhtien
            // 
            tBoThanhtien.Location = new Point(127, 115);
            tBoThanhtien.Name = "tBoThanhtien";
            tBoThanhtien.Size = new Size(163, 27);
            tBoThanhtien.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 114);
            label10.Name = "label10";
            label10.Size = new Size(118, 28);
            label10.TabIndex = 17;
            label10.Text = "Thành Tiền";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 81);
            label9.Name = "label9";
            label9.Size = new Size(98, 28);
            label9.TabIndex = 16;
            label9.Text = "Thuế: 5%";
            label9.Click += label9_Click;
            // 
            // tBoTongtien
            // 
            tBoTongtien.Location = new Point(105, 46);
            tBoTongtien.Name = "tBoTongtien";
            tBoTongtien.Size = new Size(185, 27);
            tBoTongtien.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 45);
            label8.Name = "label8";
            label8.Size = new Size(102, 28);
            label8.TabIndex = 14;
            label8.Text = "Tổng tiền";
            label8.Click += label8_Click;
            // 
            // tBoSL
            // 
            tBoSL.Location = new Point(105, 8);
            tBoSL.Name = "tBoSL";
            tBoSL.Size = new Size(185, 27);
            tBoSL.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(96, 28);
            label7.TabIndex = 13;
            label7.Text = "Số lượng";
            label7.Click += label7_Click;
            // 
            // Hoadon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 539);
            Controls.Add(panel1);
            Controls.Add(cboVoucher);
            Controls.Add(label6);
            Controls.Add(cboPhuongthuc);
            Controls.Add(label5);
            Controls.Add(tbSDTKH);
            Controls.Add(label4);
            Controls.Add(btn_remove);
            Controls.Add(cboThongTinThuoc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Hoadon";
            Text = "Hoadon";
            Load += HoadonForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ThongTinThuocColumn;
        private DataGridViewTextBoxColumn SoLuongColumn;
        private DataGridViewTextBoxColumn DonViTinhColumn;
        private DataGridViewTextBoxColumn ThanhTienColumn;
        private Label label2;
        private Label label3;
        private ComboBox cboThongTinThuoc;
        private Button btn_remove;
        private Label label4;
        private TextBox tbSDTKH;
        private Label label5;
        private ComboBox cboPhuongthuc;
        private Label label6;
        private ComboBox cboVoucher;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private TextBox tBoSL;
        private Label label9;
        private TextBox tBoTongtien;
        private Button btn_huydonhang;
        private Button btn_xuathoadon;
        private TextBox tBoThanhtien;
        private Label label10;
    }
}