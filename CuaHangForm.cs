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

                var products = (from p in db.Products
                                join pd in db.ProductDetails on p.ProductID equals pd.ProductID
                                where p.ProductName.ToLower().Contains(searchText.ToLower())
                                select new
                                {
                                    mathuoc = p.ProductID,
                                    hinhanh = !string.IsNullOrEmpty(p.ProductImage) && File.Exists(Path.Combine(Utility.ImagePath, p.ProductImage))
          ? Path.Combine(Utility.ImagePath, p.ProductImage)
          : null,
                                    tenthuoc = p.ProductName,
                                    hamluong = p.Dosage,
                                    donvitinh = p.Unit,
                                    dongia = p.Price,
                                    stock = pd.StockQuantity
                                }).ToList();

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
                dataGridView1.Columns["hinhanh"].DataPropertyName = "hinhanh";
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
                string imagePath = selectedRow.Cells["hinhanh"].Value?.ToString() ?? "";
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
                    string nameProduct = cboTenSanPham.Text.ToString().Trim();
                    if (!int.TryParse(txtSoLuongMua.Text, out int soLuong) || soLuong <= 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
                        return;
                    }

                    var product = db.Products.FirstOrDefault(p => p.ProductName.ToLower() == nameProduct.ToLower());
                    if (product == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm.");
                        return;
                    }

                    var productDetail = db.ProductDetails.FirstOrDefault(pd => pd.ProductID == product.ProductID);
                    if (productDetail == null || productDetail.StockQuantity < soLuong)
                    {
                        MessageBox.Show("Số lượng tồn không đủ!");
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
    }
}