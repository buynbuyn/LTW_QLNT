using QLNT.Data;
using QLNT.models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLNT
{
    public partial class fAddProductDetail : Form
    {
        private int _productId;

        public fAddProductDetail(int productId)
        {
            InitializeComponent();
            _productId = productId;
            this.Load += FAddProductDetail_Load;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void FAddProductDetail_Load(object sender, EventArgs e)
        {
            LoadProductInfo();
        }

        private void LoadProductInfo()
        {
            using (var db = new EFDbContext())
            {
                var product = db.Products.Find(_productId);
                if (product != null)
                {
                    lblProductName.Text = $"Sản phẩm: {product.ProductName}";
                    lblDosage.Text = $"Liều lượng: {product.Dosage}";
                    lblUnit.Text = $"Đơn vị: {product.Unit}";
                    lblPrice.Text = $"Giá: {product.Price:C}";
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime expirationDate = dtpExpirationDate.Value.Date;
                string description = txtDescription.Text.Trim();

                using (var db = new EFDbContext())
                {
                    // Check if there's an existing ProductDetail with same ProductID and ExpirationDate
                    var existingDetail = db.ProductDetails
                        .FirstOrDefault(pd => pd.ProductID == _productId &&
                                            pd.ExpirationDate.Date == expirationDate);

                    if (existingDetail != null)
                    {
                        // Update existing record - add quantity
                        existingDetail.StockQuantity += quantity;
                        // Keep existing description, don't update it

                        MessageBox.Show($"Đã cập nhật số lượng cho lô hàng có cùng ngày hết hạn!\nSố lượng mới: {existingDetail.StockQuantity}",
                            "Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Create new ProductDetail record
                        var newDetail = new ProductDetail
                        {
                            ProductID = _productId,
                            StockQuantity = quantity,
                            ExpirationDate = expirationDate,
                            Description = description
                        };

                        db.ProductDetails.Add(newDetail);
                        MessageBox.Show("Thêm lô hàng mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    db.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}