namespace QLNT
{
    partial class OrderDetailForm
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
            this.dgvDetails = new System.Windows.Forms.DataGridView(); // Đổi tên từ dataGridView1
            this.lblOrderInfo = new System.Windows.Forms.Label(); // Đổi tên từ label1
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            //
            // dgvDetails
            //
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(20, 100); // Điều chỉnh vị trí dưới thông tin chung
            this.dgvDetails.Name = "dgvDetails"; // Đổi tên thành dgvDetails
            this.dgvDetails.Size = new System.Drawing.Size(660, 180); // Điều chỉnh kích thước
            this.dgvDetails.TabIndex = 0;
            this.dgvDetails.ReadOnly = true; // Chỉ đọc
            this.dgvDetails.AllowUserToAddRows = false; // Không cho phép thêm dòng
            this.dgvDetails.AllowUserToDeleteRows = false; // Không cho phép xóa dòng
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; // Tự động điền đầy cột
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; // Chọn toàn bộ dòng
            //
            // lblOrderInfo
            //
            this.lblOrderInfo.AutoSize = true;
            this.lblOrderInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderInfo.Location = new System.Drawing.Point(20, 20); // Vị trí tiêu đề
            this.lblOrderInfo.Name = "lblOrderInfo"; // Đổi tên thành lblOrderInfo
            this.lblOrderInfo.Size = new System.Drawing.Size(167, 25);
            this.lblOrderInfo.TabIndex = 1;
            this.lblOrderInfo.Text = "Chi Tiết Hóa Đơn"; // Text ban đầu, sẽ được cập nhật bằng code
            //
            // OrderDetailForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 300); // Kích thước form
            this.Controls.Add(this.lblOrderInfo);
            this.Controls.Add(this.dgvDetails); // Đảm bảo dgvDetails được thêm vào
            this.Name = "OrderDetailForm";
            this.Text = "Chi Tiết Hóa Đơn"; // Text mặc định của form
            this.Load += new System.EventHandler(this.OrderDetailForm_Load); // Gán sự kiện Load
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Khai báo các controls đã được Designer tạo
        private System.Windows.Forms.DataGridView dgvDetails; // Đã đổi tên
        private System.Windows.Forms.Label lblOrderInfo; // Đã đổi tên
    }
}