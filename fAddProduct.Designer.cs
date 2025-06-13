namespace QLNT
{
    partial class fAddProduct
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
            this.label1 = new System.Windows.Forms.Label(); // Tiêu đề "Thêm Sản Phẩm Mới"
            this.label2 = new System.Windows.Forms.Label(); // Label cho Tên SP (ProductName)
            this.txtName = new System.Windows.Forms.TextBox(); // TextBox cho Tên SP
            this.label3 = new System.Windows.Forms.Label(); // Label cho Hàm Lượng (Dosage)
            this.txtDosage = new System.Windows.Forms.TextBox(); // TextBox cho Hàm Lượng
            this.label4 = new System.Windows.Forms.Label(); // Label cho Đơn Vị Tính (Unit)
            this.txtUnit = new System.Windows.Forms.TextBox(); // TextBox cho Đơn Vị Tính
            this.label5 = new System.Windows.Forms.Label(); // Label cho Giá (Price)
            this.txtPrice = new System.Windows.Forms.TextBox(); // TextBox cho Giá
            this.label6 = new System.Windows.Forms.Label(); // Label cho Loại (Category)
            this.cbCategory = new System.Windows.Forms.ComboBox(); // ComboBox cho Loại
            this.label7 = new System.Windows.Forms.Label(); // Label cho Nhà Sản Xuất (Manufacturer)
            this.cbManufacturer = new System.Windows.Forms.ComboBox(); // ComboBox cho Nhà Sản Xuất
            this.btnSave = new System.Windows.Forms.Button(); // Nút "Lưu"

            this.SuspendLayout();
            //
            // label1 (Tiêu đề chính)
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue; // Đổi màu để phân biệt với form sửa
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Sản Phẩm Mới";
            //
            // label2 (Tên SP)
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sản Phẩm:";
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(140, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 2;
            //
            // label3 (Hàm Lượng)
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hàm Lượng:";
            //
            // txtDosage
            //
            this.txtDosage.Location = new System.Drawing.Point(140, 87);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(200, 23);
            this.txtDosage.TabIndex = 4;
            //
            // label4 (Đơn Vị Tính)
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đơn Vị Tính:";
            //
            // txtUnit
            //
            this.txtUnit.Location = new System.Drawing.Point(140, 117);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(200, 23);
            this.txtUnit.TabIndex = 6;
            //
            // label5 (Giá)
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đơn Giá:";
            //
            // txtPrice
            //
            this.txtPrice.Location = new System.Drawing.Point(140, 147);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 23);
            this.txtPrice.TabIndex = 8;
            //
            // label6 (Loại)
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Loại:";
            //
            // cbCategory
            //
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(140, 177);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(200, 23);
            this.cbCategory.TabIndex = 10;
            //
            // label7 (Nhà Sản Xuất)
            //
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nhà Sản Xuất:";
            //
            // cbManufacturer
            //
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.Location = new System.Drawing.Point(140, 207);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(200, 23);
            this.cbManufacturer.TabIndex = 12;
            //
            // btnSave
            //
            this.btnSave.BackColor = System.Drawing.Color.LightGreen; // Màu xanh để phân biệt với form sửa/nhập kho
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(135, 260); // Điều chỉnh vị trí nút
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Thêm"; // Đổi text thành "Thêm"
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click); // Gán sự kiện Click
            //
            // fAddProduct
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 320); // Điều chỉnh kích thước form cho phù hợp
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbManufacturer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fAddProduct";
            this.Text = "Thêm Sản Phẩm Mới";
            this.Load += new System.EventHandler(this.fAddProduct_Load); // Gán sự kiện Load
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbManufacturer;
        private System.Windows.Forms.Button btnSave;
    }
}