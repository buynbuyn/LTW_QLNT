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
            dgvDetails = new DataGridView();
            lblOrderInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvDetails
            // 
            dgvDetails.AllowUserToAddRows = false;
            dgvDetails.AllowUserToDeleteRows = false;
            dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Location = new Point(12, 212);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.ReadOnly = true;
            dgvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetails.Size = new Size(703, 197);
            dgvDetails.TabIndex = 0;
            // 
            // lblOrderInfo
            // 
            lblOrderInfo.AutoSize = true;
            lblOrderInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderInfo.Location = new Point(20, 20);
            lblOrderInfo.Name = "lblOrderInfo";
            lblOrderInfo.Size = new Size(163, 25);
            lblOrderInfo.TabIndex = 1;
            lblOrderInfo.Text = "Chi Tiết Hóa Đơn";
            // 
            // OrderDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 430);
            Controls.Add(lblOrderInfo);
            Controls.Add(dgvDetails);
            Name = "OrderDetailForm";
            Text = "Chi Tiết Hóa Đơn";
            Load += OrderDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Khai báo các controls đã được Designer tạo
        private System.Windows.Forms.DataGridView dgvDetails; // Đã đổi tên
        private System.Windows.Forms.Label lblOrderInfo; // Đã đổi tên
    }
}