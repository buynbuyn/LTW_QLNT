namespace QLNT
{
    partial class KhoForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dtgvKho;
        private Label label1;
        private Button btnthemsp; // Nút "Thêm Sản Phẩm"
        private Panel panelDetails;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dtgvKho = new DataGridView();
            label1 = new Label();
            btnthemsp = new Button();
            panelDetails = new Panel();


            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Dosage = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvKho).BeginInit();
            panelDetails.SuspendLayout(); // Giữ lại dòng này cho cấu trúc, mặc dù panel trống
            SuspendLayout();
            //
            // dtgvKho
            //
            dtgvKho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvKho.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, Dosage, Unit, Price });
            dtgvKho.Location = new Point(12, 108);
            dtgvKho.Name = "dtgvKho";
            dtgvKho.Size = new Size(738, 354);
            dtgvKho.TabIndex = 0;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 1;
            label1.Text = "Kho Hàng";
            //
            // btnthemsp
            //
            btnthemsp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnthemsp.Location = new Point(975, 74);
            btnthemsp.Name = "btnthemsp";
            btnthemsp.Size = new Size(100, 28);
            btnthemsp.TabIndex = 2;
            btnthemsp.Text = "Thêm sản phẩm";
            btnthemsp.UseVisualStyleBackColor = true;
            btnthemsp.Click += Btnthemsp_Click;
            //
            // panelDetails
            //
            panelDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDetails.BorderStyle = BorderStyle.FixedSingle;
            panelDetails.Location = new Point(756, 108);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(319, 354);
            panelDetails.TabIndex = 5;
            panelDetails.Paint += panelDetails_Paint;
            //
            // ProductID
            //
            ProductID.HeaderText = "ID";
            ProductID.Name = "ProductID";
            //
            // ProductName
            //
            ProductName.HeaderText = "Tên SP";
            ProductName.Name = "ProductName";
            //
            // Dosage
            //
            Dosage.HeaderText = "Hàm Lượng";
            Dosage.Name = "Dosage";
            //
            // Unit
            //
            Unit.HeaderText = "Đơn Vị Tính";
            Unit.Name = "Unit";
            //
            // Price
            //
            Price.HeaderText = "Đơn giá ";
            Price.Name = "Price";
            //
            // KhoForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 726);
            Controls.Add(panelDetails);
            Controls.Add(btnthemsp);
            Controls.Add(label1);
            Controls.Add(dtgvKho);
            Name = "KhoForm";
            Text = "Kho Hàng";
            ((System.ComponentModel.ISupportInitialize)dtgvKho).EndInit();
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout(); // Giữ lại dòng này để đảm bảo layout đúng
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