namespace QLNT
{
    partial class KhoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dtgvKho;
        private Label label1;
        private Button btnthemsp; // Nút "Thêm Sản Phẩm"
        private Panel panelDetails;
        private TextBox txtSearch; // Thêm TextBox tìm kiếm
        private Button btnSearch; // Thêm nút tìm kiếm
        private PictureBox pbProductImage; // Khai báo PictureBox
        private TableLayoutPanel tableLayoutPanelMain; // Main layout panel
        private Panel panelTopControls; // Panel for search and add buttons
        private TableLayoutPanel tableLayoutPanelRight; // Panel for details and image

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
            dtgvKho = new DataGridView();
            label1 = new Label();
            btnthemsp = new Button();
            panelDetails = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            pbProductImage = new PictureBox(); // Khởi tạo PictureBox
            tableLayoutPanelMain = new TableLayoutPanel();
            panelTopControls = new Panel();
            tableLayoutPanelRight = new TableLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)dtgvKho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            panelTopControls.SuspendLayout();
            tableLayoutPanelRight.SuspendLayout();
            SuspendLayout();
            //
            // tableLayoutPanelMain
            //
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F)); // Left column for DataGridView
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // Right column for details and image
            tableLayoutPanelMain.Controls.Add(dtgvKho, 0, 1);
            tableLayoutPanelMain.Controls.Add(panelTopControls, 0, 0); // Top controls span both columns (if you want search to be wide)
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelRight, 1, 1); // Right panel for details and image
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F)); // Height for top controls
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); // Remaining height for DataGridView and right panels
            tableLayoutPanelMain.Size = new Size(1087, 726);
            tableLayoutPanelMain.TabIndex = 0;
            //
            // panelTopControls
            //
            panelTopControls.Controls.Add(label1);
            panelTopControls.Controls.Add(txtSearch);
            panelTopControls.Controls.Add(btnSearch);
            panelTopControls.Controls.Add(btnthemsp);
            tableLayoutPanelMain.SetColumnSpan(panelTopControls, 2); // Span across two columns
            panelTopControls.Dock = DockStyle.Fill;
            panelTopControls.Location = new Point(3, 3);
            panelTopControls.Name = "panelTopControls";
            panelTopControls.Size = new Size(1081, 94);
            panelTopControls.TabIndex = 0;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(174, 45);
            label1.Text = "Kho Hàng";
            label1.TabIndex = 1;
            //
            // txtSearch
            //
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(190, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm theo tên sản phẩm...";
            txtSearch.Size = new Size(250, 25);
            txtSearch.TabIndex = 3;
            //
            // btnSearch
            //
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(450, 58);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            //
            // btnthemsp
            //
            btnthemsp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnthemsp.BackColor = Color.ForestGreen;
            btnthemsp.FlatStyle = FlatStyle.Flat;
            btnthemsp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthemsp.ForeColor = SystemColors.ControlLightLight;
            btnthemsp.Location = new Point(930, 58);
            btnthemsp.Name = "btnthemsp";
            btnthemsp.Size = new Size(140, 29);
            btnthemsp.TabIndex = 2;
            btnthemsp.Text = "Thêm sản phẩm mới";
            btnthemsp.UseVisualStyleBackColor = false;
            //
            // dtgvKho
            //
            dtgvKho.AllowUserToAddRows = false;
            dtgvKho.AllowUserToDeleteRows = false;
            dtgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvKho.Dock = DockStyle.Fill;
            dtgvKho.Location = new Point(3, 103);
            dtgvKho.Name = "dtgvKho";
            dtgvKho.ReadOnly = true;
            dtgvKho.RowHeadersWidth = 51;
            dtgvKho.RowTemplate.Height = 29;
            dtgvKho.Size = new Size(754, 620);
            dtgvKho.TabIndex = 0;
            //
            // tableLayoutPanelRight
            //
            tableLayoutPanelRight.ColumnCount = 1;
            tableLayoutPanelRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRight.Controls.Add(panelDetails, 0, 0);
            tableLayoutPanelRight.Controls.Add(pbProductImage, 0, 1);
            tableLayoutPanelRight.Dock = DockStyle.Fill;
            tableLayoutPanelRight.Location = new Point(763, 103);
            tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            tableLayoutPanelRight.RowCount = 2;
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Percent, 60F)); // Details panel takes 60%
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Percent, 40F)); // Image box takes 40%
            tableLayoutPanelRight.Size = new Size(321, 620);
            tableLayoutPanelRight.TabIndex = 1;
            //
            // panelDetails
            //
            panelDetails.BorderStyle = BorderStyle.FixedSingle;
            panelDetails.Dock = DockStyle.Fill;
            panelDetails.Location = new Point(3, 3);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(315, 366);
            panelDetails.TabIndex = 5;
            panelDetails.Visible = false; // Initially hidden
            panelDetails.Paint += panelDetails_Paint;
            //
            // pbProductImage
            //
            pbProductImage.BorderStyle = BorderStyle.FixedSingle;
            pbProductImage.Dock = DockStyle.Fill;
            pbProductImage.Location = new Point(3, 375);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(315, 242);
            pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbProductImage.TabIndex = 6;
            pbProductImage.TabStop = false;
            pbProductImage.Visible = false; // Initially hidden, shown when an image is loaded
            //
            // KhoForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 726);
            Controls.Add(tableLayoutPanelMain);
            Name = "KhoForm";
            Text = "Kho Hàng";
            ((System.ComponentModel.ISupportInitialize)dtgvKho).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelTopControls.ResumeLayout(false);
            panelTopControls.PerformLayout();
            tableLayoutPanelRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Remove the DataGridViewTextBoxColumn declarations here, as AutoGenerateColumns will handle them.
        // If you need custom columns defined in designer, ensure AutoGenerateColumns is false and define them explicitly.
        // For simplicity and common use cases, AutoGenerateColumns = true is often used with dynamic data.
        // private DataGridViewTextBoxColumn ProductID;
        // private DataGridViewTextBoxColumn ProductName;
        // private DataGridViewTextBoxColumn Dosage;
        // private DataGridViewTextBoxColumn Unit;
        // private DataGridViewTextBoxColumn Price;
    }
}