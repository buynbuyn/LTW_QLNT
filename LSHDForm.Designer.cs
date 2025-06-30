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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox(); // New: Search TextBox
            this.btnSearch = new System.Windows.Forms.Button(); // New: Search Button
            this.lblFilterByDate = new System.Windows.Forms.Label(); // New: Label for date filter
            this.cbDay = new System.Windows.Forms.ComboBox(); // New: Day ComboBox
            this.cbMonth = new System.Windows.Forms.ComboBox(); // New: Month ComboBox
            this.cbYear = new System.Windows.Forms.ComboBox(); // New: Year ComboBox
            this.btnFilter = new System.Windows.Forms.Button(); // New: Filter Button
            this.btnFindInvoice = new System.Windows.Forms.Button(); // Existing
            this.pnlRightActions = new System.Windows.Forms.Panel(); // Existing
            this.btnCancelDelete = new System.Windows.Forms.Button(); // Existing
            this.btnDeleteInvoice = new System.Windows.Forms.Button(); // Existing
            this.txtInvoiceIDToDelete = new System.Windows.Forms.TextBox(); // Existing
            this.lblDeleteInstruction = new System.Windows.Forms.Label(); // Existing
            this.lblDeleteTitle = new System.Windows.Forms.Label(); // Existing

            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlRightActions.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Lịch sử hóa đơn";
            //
            // txtSearch
            //

            this.txtSearch.Location = new System.Drawing.Point(230, 20); // Adjust location
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 23);
            this.txtSearch.TabIndex = 2;
            //
            // btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(420, 19); // Adjust location
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            //
            // lblFilterByDate
            //
            this.lblFilterByDate.AutoSize = true;
            this.lblFilterByDate.Location = new System.Drawing.Point(12, 65); // Adjust location
            this.lblFilterByDate.Name = "lblFilterByDate";
            this.lblFilterByDate.Size = new System.Drawing.Size(110, 15);
            this.lblFilterByDate.TabIndex = 4;
            this.lblFilterByDate.Text = "Lọc theo ngày:";
            //
            // cbDay
            //
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(130, 62); // Adjust location
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(60, 23);
            this.cbDay.TabIndex = 5;
            //
            // cbMonth
            //
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(200, 62); // Adjust location
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(70, 23);
            this.cbMonth.TabIndex = 6;
            //
            // cbYear
            //
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(280, 62); // Adjust location
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(80, 23);
            this.cbYear.TabIndex = 7;
            //
            // btnFilter
            //
            this.btnFilter.Location = new System.Drawing.Point(370, 61); // Adjust location
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 25);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            //
            // dgvOrders
            //
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 100); // Adjusted location below search and filter
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(560, 379); // Mở rộng chiều rộng để phù hợp với ảnh
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            //
            // btnFindInvoice
            //
            this.btnFindInvoice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFindInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindInvoice.Location = new System.Drawing.Point(590, 59); // Keep existing location relative to original design
            this.btnFindInvoice.Name = "btnFindInvoice";
            this.btnFindInvoice.Size = new System.Drawing.Size(180, 35);
            this.btnFindInvoice.TabIndex = 9; // Changed TabIndex
            this.btnFindInvoice.Text = "Tìm hóa đơn";
            this.btnFindInvoice.UseVisualStyleBackColor = false;

            //this.btnFindInvoice.Click += new System.EventHandler(this.BtnFindInvoice_Click);

            //
            // pnlRightActions
            //
            this.pnlRightActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRightActions.Controls.Add(this.btnCancelDelete);
            this.pnlRightActions.Controls.Add(this.btnDeleteInvoice);
            this.pnlRightActions.Controls.Add(this.txtInvoiceIDToDelete);
            this.pnlRightActions.Controls.Add(this.lblDeleteInstruction);
            this.pnlRightActions.Controls.Add(this.lblDeleteTitle);
            this.pnlRightActions.Location = new System.Drawing.Point(590, 100);
            this.pnlRightActions.Name = "pnlRightActions";
            this.pnlRightActions.Size = new System.Drawing.Size(180, 200);
            this.pnlRightActions.TabIndex = 10; // Changed TabIndex
            //
            // btnCancelDelete
            //
            this.btnCancelDelete.Location = new System.Drawing.Point(15, 150);
            this.btnCancelDelete.Name = "btnCancelDelete";
            this.btnCancelDelete.Size = new System.Drawing.Size(150, 25);
            this.btnCancelDelete.TabIndex = 4;
            this.btnCancelDelete.Text = "Hủy";
            this.btnCancelDelete.UseVisualStyleBackColor = true;

            //this.btnCancelDelete.Click += new System.EventHandler(this.BtnCancelDelete_Click);

            //
            // btnDeleteInvoice
            //
            this.btnDeleteInvoice.BackColor = System.Drawing.Color.Red;
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(15, 115);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteInvoice.TabIndex = 3;
            this.btnDeleteInvoice.Text = "Xóa hóa đơn";
            this.btnDeleteInvoice.UseVisualStyleBackColor = false;

            //this.btnDeleteInvoice.Click += new System.EventHandler(this.BtnDeleteInvoice_Click);

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
            this.lblDeleteTitle.Location = new System.Drawing.Point(45, 15);
            this.lblDeleteTitle.Name = "lblDeleteTitle";
            this.lblDeleteTitle.Size = new System.Drawing.Size(107, 21);
            this.lblDeleteTitle.TabIndex = 0;
            this.lblDeleteTitle.Text = "Xóa hóa đơn";
            //
            // LSHDForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 500); // Increased ClientSize height to accommodate new controls
            this.Controls.Add(this.btnFilter); // Add filter button
            this.Controls.Add(this.cbYear); // Add year combobox
            this.Controls.Add(this.cbMonth); // Add month combobox
            this.Controls.Add(this.cbDay); // Add day combobox
            this.Controls.Add(this.lblFilterByDate); // Add filter label
            this.Controls.Add(this.btnSearch); // Add search button
            this.Controls.Add(this.txtSearch); // Add search textbox
            this.Controls.Add(this.pnlRightActions);
            this.Controls.Add(this.btnFindInvoice);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvOrders);
            this.Name = "LSHDForm";
            this.Text = "Lịch sử hóa đơn";
            this.Load += new System.EventHandler(this.LSHDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlRightActions.ResumeLayout(false);
            this.pnlRightActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Khai báo các controls
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch; // New: Search TextBox
        private System.Windows.Forms.Button btnSearch; // New: Search Button
        private System.Windows.Forms.Label lblFilterByDate; // New: Label for date filter
        private System.Windows.Forms.ComboBox cbDay; // New: Day ComboBox
        private System.Windows.Forms.ComboBox cbMonth; // New: Month ComboBox
        private System.Windows.Forms.ComboBox cbYear; // New: Year ComboBox
        private System.Windows.Forms.Button btnFilter; // New: Filter Button
        private System.Windows.Forms.Button btnFindInvoice;
        private System.Windows.Forms.Panel pnlRightActions;
        private System.Windows.Forms.Button btnCancelDelete;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.TextBox txtInvoiceIDToDelete;
        private System.Windows.Forms.Label lblDeleteInstruction;
        private System.Windows.Forms.Label lblDeleteTitle;
    }
}