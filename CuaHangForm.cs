using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QLNT.Data;
using QLNT.models;

namespace QLNT
{
    public partial class CuaHangForm : Form
    {

        public CuaHangForm()
        {
            InitializeComponent();
            findProduct.Focus();
        }

        private void findProduct_Enter(object sender, EventArgs e)
        {
            if (findProduct.Text == "Nhập tên sản phẩm...")
            {
                findProduct.Text = "";
                findProduct.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void findProduct_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(findProduct.Text))
            {
                findProduct.Text = "Nhập tên sản phẩm...";
                findProduct.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btn_findProduct_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                string searchText = findProduct.Text.Trim();



                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = false;

                var products = db.Products
                    .Where(p => p.ProductName.ToLower().Contains(searchText.ToLower()))
                    .Select(p => new
                    {
                        mathuoc = p.ProductID,
                        tenthuoc = p.ProductName,
                        hamluong = p.Dosage,
                        donvitinh = p.Unit,
                        dongia = p.Price,

                        // 🌟 lấy tồn kho tương ứng của lô sắp hết hạn nhất
                        stock = p.ProductDetails
                            .Where(pd => pd.StockQuantity > 0)
                            .OrderBy(pd => pd.ExpirationDate)
                            .Select(pd => pd.StockQuantity)
                            .FirstOrDefault(),

                        // 🌟 lấy ngày hết hạn gần nhất
                        expiration = p.ProductDetails
                            .Where(pd => pd.StockQuantity > 0)
                            .OrderBy(pd => pd.ExpirationDate)
                            .Select(pd => pd.ExpirationDate)
                            .FirstOrDefault()
                    })
                    .ToList();

                if (products == null || !products.Any())
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào!");
                    dataGridView1.DataSource = null;
                    cboTenSanPham.DataSource = null;
                    cboMaSanPham.DataSource = null;
                    return;
                }

                cboTenSanPham.DataSource = products.ToList();
                cboTenSanPham.DisplayMember = "tenthuoc";
                cboTenSanPham.ValueMember = "tenthuoc";

                cboMaSanPham.DataSource = products.ToList();
                cboMaSanPham.DisplayMember = "mathuoc";
                cboMaSanPham.ValueMember = "mathuoc";

                dataGridView1.DataSource = products;
                dataGridView1.Refresh();

                dataGridView1.Columns["mathuoc"].DataPropertyName = "mathuoc";
                dataGridView1.Columns["tenthuoc"].DataPropertyName = "tenthuoc";
                dataGridView1.Columns["hamluong"].DataPropertyName = "hamluong";
                dataGridView1.Columns["donvitinh"].DataPropertyName = "donvitinh";
                dataGridView1.Columns["dongia"].DataPropertyName = "dongia";
                if (dataGridView1.Columns["stock"] == null)
                {
                    DataGridViewTextBoxColumn stockColumn = new DataGridViewTextBoxColumn();
                    stockColumn.HeaderText = "Số lượng tồn";
                    stockColumn.Name = "stock";
                    stockColumn.Width = 200;
                    dataGridView1.Columns.Add(stockColumn);
                }
                dataGridView1.Columns["stock"].DataPropertyName = "stock";

                if (dataGridView1.Columns["expiration"] == null)
                {
                    DataGridViewTextBoxColumn expirationColumn = new DataGridViewTextBoxColumn();
                    expirationColumn.HeaderText = "Hạn sử dụng";
                    expirationColumn.Name = "expiration";
                    expirationColumn.Width = 200;
                    dataGridView1.Columns.Add(expirationColumn);
                }
                dataGridView1.Columns["expiration"].DataPropertyName = "expiration";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
                {
                    MessageBox.Show("Vui lòng chọn một hàng hợp lệ!");
                    return;
                }

                // Lấy dòng được chọn
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                // Lấy thông tin sản phẩm
                int productId = Convert.ToInt32(selectedRow.Cells["mathuoc"].Value ?? 0);
                string productName = selectedRow.Cells["tenthuoc"].Value?.ToString() ?? "Không có tên";
                string dosage = selectedRow.Cells["hamluong"].Value?.ToString() ?? "Không có dữ liệu";
                string unit = selectedRow.Cells["donvitinh"].Value?.ToString() ?? "Không có dữ liệu";
                decimal price = selectedRow.Cells["dongia"].Value != null ? Convert.ToDecimal(selectedRow.Cells["dongia"].Value) : 0m;
                int stock = selectedRow.Cells["stock"].Value != null ? Convert.ToInt32(selectedRow.Cells["stock"].Value) : 0;

                // Cập nhật các điều khiển
                cboMaSanPham.Text = productId.ToString();
                cboTenSanPham.Text = productName;

                pnlChiTietSanPham.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }

        private void btnThemVaoGioHang_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new EFDbContext())
                {

                    string searchText = findProduct.Text.Trim();
                    if (searchText == null || searchText == "")
                    {
                        label6.Text = "Vui lòng tìm kiếm sản phẩm muốn thêm!";
                        findProduct.Focus();
                        return;
                    }

                    string nameProduct = cboTenSanPham.Text.ToString().Trim();
                    if (!int.TryParse(txtSoLuongMua.Text, out int soLuong) || soLuong <= 0)
                    {
                        label6.Text = "Vui lòng nhập số lượng mua!";
                        txtSoLuongMua.Focus();
                        return;
                    }


                    var product = db.Products.FirstOrDefault(p => p.ProductName.ToLower() == nameProduct.ToLower());
                    if (product == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm!");
                        return;
                    }

                    var productDetail = db.ProductDetails
                    .Where(pd => pd.ProductID == product.ProductID && pd.StockQuantity > 0)
                    .OrderBy(pd => pd.ExpirationDate)
                    .FirstOrDefault();
                    if (productDetail == null || productDetail.StockQuantity < soLuong)
                    {
                        label6.Text = "Số lượng tồn kho không đủ!";
                        return;
                    }

                    using (var transaction = db.Database.BeginTransaction())
                    {

                        int? customerId = 1;

                        int? userId = Utility.UserID;

                        // Kiểm tra xem người dùng đã có giỏ hàng chưa
                        var existingCart = db.Carts.FirstOrDefault(c => c.UserID == userId && c.CustomerID == customerId);
                        Cart cart;

                        if (existingCart == null)
                        {
                            cart = new Cart
                            {
                                CustomerID = customerId,
                                UserID = userId,
                                TotalCartPrice = product.Price * soLuong
                            };
                            db.Carts.Add(cart);
                            db.SaveChanges();

                        }
                        else
                        {
                            cart = existingCart;
                            cart.TotalCartPrice += product.Price * soLuong;
                        }
                        db.SaveChanges();

                        CartDetail detail = new CartDetail
                        {
                            CartID = cart.CartID,
                            ProductID = product.ProductID,
                            Quantity = soLuong,
                            UnitPrice = product.Price
                        };

                        db.CartDetails.Add(detail);
                        db.SaveChanges();

                        productDetail.StockQuantity -= soLuong;
                        db.SaveChanges();

                        transaction.Commit();
                        MessageBox.Show("Thêm vào giỏ hàng thành công.");
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                // Bắt lỗi cụ thể từ EF Core
                string errorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {errorMessage}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}\nChi tiết: {ex.InnerException?.Message}");
            }
        }

        private void CuaHangForm_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void LoadProductList(string searchText = "")
        {
            using (var db = new EFDbContext())
            {
                var query = db.Products.AsQueryable();

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    query = query.Where(p => p.ProductName.ToLower().Contains(searchText.ToLower()));
                }

                var products = query
                    .Select(p => new
                    {
                        mathuoc = p.ProductID,
                        tenthuoc = p.ProductName,
                        hamluong = p.Dosage,
                        donvitinh = p.Unit,
                        dongia = p.Price,
                        stock = p.ProductDetails
                            .Where(pd => pd.StockQuantity > 0)
                            .OrderBy(pd => pd.ExpirationDate)
                            .Select(pd => pd.StockQuantity)
                            .FirstOrDefault(),
                        expiration = p.ProductDetails
                            .Where(pd => pd.StockQuantity > 0)
                            .OrderBy(pd => pd.ExpirationDate)
                            .Select(pd => pd.ExpirationDate)
                            .FirstOrDefault()
                    })
                    .ToList();

                if (!products.Any())
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào!");
                    dataGridView1.DataSource = null;
                    cboTenSanPham.DataSource = null;
                    cboMaSanPham.DataSource = null;
                    return;
                }

                cboTenSanPham.DataSource = products;
                cboTenSanPham.DisplayMember = "tenthuoc";
                cboTenSanPham.ValueMember = "tenthuoc";

                cboMaSanPham.DataSource = products;
                cboMaSanPham.DisplayMember = "mathuoc";
                cboMaSanPham.ValueMember = "mathuoc";

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = products;

                dataGridView1.Columns["mathuoc"].DataPropertyName = "mathuoc";
                dataGridView1.Columns["tenthuoc"].DataPropertyName = "tenthuoc";
                dataGridView1.Columns["hamluong"].DataPropertyName = "hamluong";
                dataGridView1.Columns["donvitinh"].DataPropertyName = "donvitinh";
                dataGridView1.Columns["dongia"].DataPropertyName = "dongia";

                if (dataGridView1.Columns["stock"] == null)
                {
                    var stockColumn = new DataGridViewTextBoxColumn();
                    stockColumn.HeaderText = "Số lượng tồn";
                    stockColumn.Name = "stock";
                    stockColumn.Width = 200;
                    dataGridView1.Columns.Add(stockColumn);
                }
                dataGridView1.Columns["stock"].DataPropertyName = "stock";

                if (dataGridView1.Columns["expiration"] == null)
                {
                    var expirationColumn = new DataGridViewTextBoxColumn();
                    expirationColumn.HeaderText = "Hạn sử dụng";
                    expirationColumn.Name = "expiration";
                    expirationColumn.Width = 200;
                    dataGridView1.Columns.Add(expirationColumn);
                }
                dataGridView1.Columns["expiration"].DataPropertyName = "expiration";
            }
        }
    }
}