namespace QLNT
{
    partial class LSHDForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView(); // Đổi tên từ dataGridView1 sang dgvOrders
            this.btnFindInvoice = new System.Windows.Forms.Button();
            this.pnlRightActions = new System.Windows.Forms.Panel();
            this.btnCancelDelete = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.txtInvoiceIDToDelete = new System.Windows.Forms.TextBox();
            this.lblDeleteInstruction = new System.Windows.Forms.Label();
            this.lblDeleteTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlRightActions.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9); // Vị trí tiêu đề
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Lịch sử hóa đơn";
            //
            // dgvOrders
            //
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 59);
            this.dgvOrders.Name = "dgvOrders"; // Đổi tên thành dgvOrders
            this.dgvOrders.Size = new System.Drawing.Size(560, 379); // Mở rộng chiều rộng để phù hợp với ảnh
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellDoubleClick); // Gán sự kiện DoubleClick
            //
            // btnFindInvoice
            //
            this.btnFindInvoice.BackColor = System.Drawing.Color.LightSkyBlue; // Màu xanh nhạt
            this.btnFindInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindInvoice.Location = new System.Drawing.Point(590, 59); // Đặt gần dgvOrders
            this.btnFindInvoice.Name = "btnFindInvoice";
            this.btnFindInvoice.Size = new System.Drawing.Size(180, 35);
            this.btnFindInvoice.TabIndex = 2;
            this.btnFindInvoice.Text = "Tìm hóa đơn";
            this.btnFindInvoice.UseVisualStyleBackColor = false;
            this.btnFindInvoice.Click += new System.EventHandler(this.BtnFindInvoice_Click); // Gán sự kiện Click
            //
            // pnlRightActions
            //
            this.pnlRightActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRightActions.Controls.Add(this.btnCancelDelete);
            this.pnlRightActions.Controls.Add(this.btnDeleteInvoice);
            this.pnlRightActions.Controls.Add(this.txtInvoiceIDToDelete);
            this.pnlRightActions.Controls.Add(this.lblDeleteInstruction);
            this.pnlRightActions.Controls.Add(this.lblDeleteTitle);
            this.pnlRightActions.Location = new System.Drawing.Point(590, 100); // Đặt dưới nút tìm
            this.pnlRightActions.Name = "pnlRightActions";
            this.pnlRightActions.Size = new System.Drawing.Size(180, 200); // Kích thước panel
            this.pnlRightActions.TabIndex = 3;
            //
            // btnCancelDelete
            //
            this.btnCancelDelete.Location = new System.Drawing.Point(15, 150);
            this.btnCancelDelete.Name = "btnCancelDelete";
            this.btnCancelDelete.Size = new System.Drawing.Size(150, 25);
            this.btnCancelDelete.TabIndex = 4;
            this.btnCancelDelete.Text = "Hủy";
            this.btnCancelDelete.UseVisualStyleBackColor = true;
            this.btnCancelDelete.Click += new System.EventHandler(this.BtnCancelDelete_Click); // Gán sự kiện Click
            //
            // btnDeleteInvoice
            //
            this.btnDeleteInvoice.BackColor = System.Drawing.Color.Red; // Nút xóa màu đỏ
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(15, 115);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteInvoice.TabIndex = 3;
            this.btnDeleteInvoice.Text = "Xóa hóa đơn";
            this.btnDeleteInvoice.UseVisualStyleBackColor = false;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.BtnDeleteInvoice_Click); // Gán sự kiện Click
            //
            // txtInvoiceIDToDelete
            //
            this.txtInvoiceIDToDelete.Location = new System.Drawing.Point(15, 80);
            this.txtInvoiceIDToDelete.Name = "txtInvoiceIDToDelete";
            this.txtInvoiceIDToDelete.Size = new System.Drawing.Size(150, 23);
            this.txtInvoiceIDToDelete.TabIndex = 2;
            //
            // lblDeleteInstruction
            //
            this.lblDeleteInstruction.AutoSize = true;
            this.lblDeleteInstruction.Location = new System.Drawing.Point(12, 60);
            this.lblDeleteInstruction.Name = "lblDeleteInstruction";
            this.lblDeleteInstruction.Size = new System.Drawing.Size(117, 15);
            this.lblDeleteInstruction.TabIndex = 1;
            this.lblDeleteInstruction.Text = "Mã hóa đơn cần xóa:";
            //
            // lblDeleteTitle
            //
            this.lblDeleteTitle.AutoSize = true;
            this.lblDeleteTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTitle.Location = new System.Drawing.Point(45, 15); // Canh giữa panel
            this.lblDeleteTitle.Name = "lblDeleteTitle";
            this.lblDeleteTitle.Size = new System.Drawing.Size(107, 21);
            this.lblDeleteTitle.TabIndex = 0;
            this.lblDeleteTitle.Text = "Xóa hóa đơn";
            //
            // LSHDForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461); // Kích thước form
            this.Controls.Add(this.pnlRightActions);
            this.Controls.Add(this.btnFindInvoice);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvOrders); // Đảm bảo dgvOrders là control đầu tiên được thêm
            this.Name = "LSHDForm";
            this.Text = "Lịch sử hóa đơn";
            this.Load += new System.EventHandler(this.LSHDForm_Load); // Gán sự kiện Load
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlRightActions.ResumeLayout(false);
            this.pnlRightActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Khai báo các controls
        private System.Windows.Forms.DataGridView dgvOrders; // Đã đổi tên
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnFindInvoice;
        private System.Windows.Forms.Panel pnlRightActions;
        private System.Windows.Forms.Button btnCancelDelete;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.TextBox txtInvoiceIDToDelete;
        private System.Windows.Forms.Label lblDeleteInstruction;
        private System.Windows.Forms.Label lblDeleteTitle;
    }
}