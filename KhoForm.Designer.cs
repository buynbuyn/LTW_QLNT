namespace QLNT
{
    partial class KhoForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dtgvKho;
        private Label label1;
        private Button btnthemsp; // Nút "Thêm Sản Phẩm"
        private Panel panelDetails;
        private TextBox txtSearch; // Thêm TextBox tìm kiếm
        private Button btnSearch; // Thêm nút tìm kiếm

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dtgvKho = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Dosage = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnthemsp = new Button();
            panelDetails = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvKho).BeginInit();
            SuspendLayout();
            // 
            // dtgvKho
            // 
            dtgvKho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvKho.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, Dosage, Unit, Price });
            dtgvKho.Location = new Point(14, 144);
            dtgvKho.Margin = new Padding(3, 4, 3, 4);
            dtgvKho.Name = "dtgvKho";
            dtgvKho.RowHeadersWidth = 51;
            dtgvKho.Size = new Size(746, 472);
            dtgvKho.TabIndex = 0;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Tên SP";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            // 
            // Dosage
            // 
            Dosage.HeaderText = "Hàm Lượng";
            Dosage.MinimumWidth = 6;
            Dosage.Name = "Dosage";
            // 
            // Unit
            // 
            Unit.HeaderText = "Đơn Vị Tính";
            Unit.MinimumWidth = 6;
            Unit.Name = "Unit";
            // 
            // Price
            // 
            Price.HeaderText = "Đơn giá ";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(14, 76);
            label1.Name = "label1";
            label1.Size = new Size(178, 46);
            label1.TabIndex = 1;
            label1.Text = "Kho Hàng";
            // 
            // btnthemsp
            // 
            btnthemsp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnthemsp.Location = new Point(984, 99);
            btnthemsp.Margin = new Padding(3, 4, 3, 4);
            btnthemsp.Name = "btnthemsp";
            btnthemsp.Size = new Size(138, 37);
            btnthemsp.TabIndex = 2;
            btnthemsp.Text = "Thêm sản phẩm";
            btnthemsp.UseVisualStyleBackColor = true;
            // 
            // panelDetails
            // 
            panelDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDetails.BorderStyle = BorderStyle.FixedSingle;
            panelDetails.Location = new Point(703, 144);
            panelDetails.Margin = new Padding(3, 4, 3, 4);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(478, 471);
            panelDetails.TabIndex = 5;
            panelDetails.Paint += panelDetails_Paint;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(194, 99);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(228, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(434, 99);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // KhoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 968);
            Controls.Add(panelDetails);
            Controls.Add(btnthemsp);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dtgvKho);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KhoForm";
            Text = "Kho Hàng";
            ((System.ComponentModel.ISupportInitialize)dtgvKho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Dosage;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Price;
    }
}