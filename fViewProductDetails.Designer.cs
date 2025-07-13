using QLNT.Data;
using QLNT.models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLNT
{
    public partial class fViewProductDetails : Form
    {
        private int ProductID;
        private Label lblTitle;
        private Label lblProductName;
        private Label lblDosage;
        private Label lblUnit;
        private Label lblPrice;
        private Label lblManufacturer;
        private Label lblCategory;
        private DataGridView dtgvProductDetails;
        private Label lblNoData;

        public fViewProductDetails(int productID)
        {
            ProductID = productID;
            InitializeComponent();
            LoadProductDetails();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblProductName = new Label();
            this.lblDosage = new Label();
            this.lblUnit = new Label();
            this.lblPrice = new Label();
            this.lblManufacturer = new Label();
            this.lblCategory = new Label();
            this.dtgvProductDetails = new DataGridView();
            this.lblNoData = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductDetails)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.DarkBlue;
            this.lblTitle.Location = new Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(190, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chi Tiết Sản Phẩm";

            // lblProductName
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblProductName.Location = new Point(12, 45);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new Size(100, 19);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Tên sản phẩm:";

            // lblDosage
            this.lblDosage.AutoSize = true;
            this.lblDosage.Font = new Font("Segoe UI", 9F);
            this.lblDosage.Location = new Point(12, 75);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new Size(54, 15);
            this.lblDosage.TabIndex = 2;
            this.lblDosage.Text = "Liều lượng:";

            // lblUnit
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new Font("Segoe UI", 9F);
            this.lblUnit.Location = new Point(12, 100);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new Size(56, 15);
            this.lblUnit.TabIndex = 3;
            this.lblUnit.Text = "Đơn vị:";

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new Font("Segoe UI", 9F);
            this.lblPrice.Location = new Point(12, 125);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new Size(52, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Giá bán:";

            // lblManufacturer
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new Font("Segoe UI", 9F);
            this.lblManufacturer.Location = new Point(12, 150);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new Size(87, 15);
            this.lblManufacturer.TabIndex = 5;
            this.lblManufacturer.Text = "Nhà sản xuất:";

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new Font("Segoe UI", 9F);
            this.lblCategory.Location = new Point(12, 175);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new Size(63, 15);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Danh mục:";

            // dtgvProductDetails
            this.dtgvProductDetails.AllowUserToAddRows = false;
            this.dtgvProductDetails.AllowUserToDeleteRows = false;
            this.dtgvProductDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProductDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductDetails.Location = new Point(12, 230);
            this.dtgvProductDetails.Name = "dtgvProductDetails";
            this.dtgvProductDetails.ReadOnly = true;
            this.dtgvProductDetails.RowHeadersWidth = 51;
            this.dtgvProductDetails.RowTemplate.Height = 29;
            this.dtgvProductDetails.Size = new Size(290, 200);
            this.dtgvProductDetails.TabIndex = 7;

            // lblNoData
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            this.lblNoData.ForeColor = Color.Gray;
            this.lblNoData.Location = new Point(12, 205);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new Size(180, 15);
            this.lblNoData.TabIndex = 8;
            this.lblNoData.Text = "Thông tin chi tiết trong kho:";

            // fViewProductDetails
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(314, 442);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.dtgvProductDetails);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblDosage);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblTitle);
            this.Name = "fViewProductDetails";
            this.Text = "Chi Tiết Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadProductDetails()
        {
            using (var db = new EFDbContext())
            {
                // Lấy thông tin sản phẩm
                var product = db.Products.Find(ProductID);
                if (product != null)
                {
                    lblProductName.Text = $"Tên sản phẩm: {product.ProductName}";
                    lblDosage.Text = $"Liều lượng: {product.Dosage}";
                    lblUnit.Text = $"Đơn vị: {product.Unit}";
                    lblPrice.Text = $"Giá bán: {product.Price:C}";

                    // Lấy thông tin chi tiết trong kho (không hiển thị ProductDetailID)
                    var productDetails = db.ProductDetails
                        .Where(pd => pd.ProductID == ProductID)
                        .Select(pd => new
                        {
                            SoLuong = pd.StockQuantity,
                            NgayHetHan = pd.ExpirationDate,
                            MoTa = pd.Description ?? "N/A"
                        })
                        .ToList();

                    if (productDetails.Any())
                    {
                        dtgvProductDetails.DataSource = productDetails;
                        dtgvProductDetails.Columns["SoLuong"].HeaderText = "Số Lượng";
                        dtgvProductDetails.Columns["NgayHetHan"].HeaderText = "Ngày Hết Hạn";
                        dtgvProductDetails.Columns["MoTa"].HeaderText = "Mô Tả";
                    }
                    else
                    {
                        dtgvProductDetails.DataSource = null;
                        lblNoData.Text = "Không có dữ liệu chi tiết trong kho.";
                        lblNoData.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}