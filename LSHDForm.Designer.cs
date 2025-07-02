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
            lblTitle = new Label();
            dgvOrders = new DataGridView();
            pnlRightActions = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(18, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(307, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "LỊCH SỬ HÓA ĐƠN";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.WhiteSmoke;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 64);
            dgvOrders.Margin = new Padding(3, 2, 3, 2);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(773, 360);
            dgvOrders.TabIndex = 0;
            // 
            // pnlRightActions
            // 
            pnlRightActions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlRightActions.BorderStyle = BorderStyle.FixedSingle;
            pnlRightActions.Location = new Point(803, 64);
            pnlRightActions.Margin = new Padding(3, 2, 3, 2);
            pnlRightActions.Name = "pnlRightActions";
            pnlRightActions.Size = new Size(324, 345);
            pnlRightActions.TabIndex = 3;
            // 
            // LSHDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1144, 450);
            Controls.Add(pnlRightActions);
            Controls.Add(lblTitle);
            Controls.Add(dgvOrders);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(877, 460);
            Name = "LSHDForm";
            Text = "Lịch sử hóa đơn";
            Load += LSHDForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlRightActions;
    }
}