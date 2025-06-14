using QLNT.Data;
using QLNT.models;
using System;
using System.Linq;
using System.Windows.Forms;
// using System.Xml.Linq; // Không cần thiết nếu không dùng XML

namespace QLNT
{
    public partial class fAddProduct : Form
    {
        public fAddProduct()
        {
            InitializeComponent();
        }

        private void fAddProduct_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                // Load Category (Loại)
                cbCategory.DataSource = db.Categories.ToList();
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";

                // Load Manufacturer (Nhà Sản Xuất)
                cbManufacturer.DataSource = db.Manufacturers.ToList();
                cbManufacturer.DisplayMember = "ManufacturerName";
                cbManufacturer.ValueMember = "ManufacturerID";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường dữ liệu có bị bỏ trống không
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDosage.Text) ||
                string.IsNullOrWhiteSpace(txtUnit.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá có phải là số hợp lệ không
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Giá nhập vào không hợp lệ. Vui lòng nhập một số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus(); // Đặt con trỏ vào ô giá
                return;
            }

            // Kiểm tra ComboBox đã chọn giá trị chưa (nếu có thể null)
            if (cbCategory.SelectedValue == null || cbManufacturer.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Loại và Nhà Sản Xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                using (var db = new EFDbContext())
                {
                    var newProduct = new Product()
                    {
                        ProductName = txtName.Text,
                        Dosage = txtDosage.Text,
                        Unit = txtUnit.Text,
                        Price = price, // Sử dụng biến 'price' đã được parse
                        CategoryID = (int)cbCategory.SelectedValue,
                        ManufactureID = (int)cbManufacturer.SelectedValue,
                    };

                    db.Products.Add(newProduct);
                    db.SaveChanges();
                    MessageBox.Show("Đã thêm sản phẩm mới thành công.");
                    this.Close(); // Đóng form sau khi thêm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi thêm sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}