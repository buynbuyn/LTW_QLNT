using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QLNT.Data;
using QLNT.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNT
{
    public partial class Hoadon : Form
    {
        private readonly EFDbContext _context;
        private Cart _currentCart;
        private int? _userId; // Lấy từ Utility
        private int? _customerId = 1; // Giả sử CustomerID mặc định
        private int _cartId;

        public Hoadon()
        {
            InitializeComponent();
            _context = new EFDbContext();
            _currentCart = null;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void HoadonForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra UserID
                _userId = Utility.UserID;
                if (!_userId.HasValue)
                {
                    MessageBox.Show("Vui lòng đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DisableControls();
                    return;
                }

                // Sử dụng DbContext toàn cục
                _currentCart = _context.Carts
                    .Include(c => c.Customer)
                    .Include(c => c.CartDetails)
                    .ThenInclude(cd => cd.Product)
                    .FirstOrDefault(c => c.UserID == _userId.Value);

                if (_currentCart == null)
                {
                    // Tạo giỏ hàng mới nếu chưa tồn tại
                    _currentCart = new Cart
                    {
                        UserID = _userId.Value,
                        CustomerID = _customerId ?? 1, // Khách hàng mặc định
                        TotalCartPrice = 0m
                    };
                    _context.Carts.Add(_currentCart);
                    _context.SaveChanges();
                    _cartId = _currentCart.CartID; // Lấy CartID từ CSDL (giả sử CartID là auto-increment)
                    MessageBox.Show($"Tạo giỏ hàng mới cho UserID {_userId.Value}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _cartId = _currentCart.CartID; // Sử dụng CartID hiện có
                }

                // Kiểm tra giỏ hàng rỗng
                if (!_currentCart.CartDetails.Any())
                {
                    MessageBox.Show("Giỏ hàng hiện tại trống! Vui lòng thêm sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DisableControls();
                    return;
                }

                // Đặt các TextBox thành ReadOnly
                tBoSL.ReadOnly = true;
                tBoTongtien.ReadOnly = true;
                tBoThanhtien.ReadOnly = true;

                // Cập nhật giao diện
                UpdateUI();
            }
            catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 2627)
            {
                MessageBox.Show($"Giỏ hàng cho UserID {_userId.Value} đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải giỏ hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisableControls()
        {
            cboThongTinThuoc.Enabled = false;
            dataGridView1.Enabled = false;
            btn_remove.Enabled = false;
            btn_xuathoadon.Enabled = false;
        }

        private void UpdateUI()
        {
            tbSDTKH.Text = _currentCart.Customer?.PhoneNumber ?? "N/A";
            cboPhuongthuc.Items.AddRange(new string[] { "Cash", "Chuyển khoản", "Thẻ tín dụng" });
            cboPhuongthuc.SelectedIndex = 0;
            cboVoucher.Items.AddRange(new string[] { "Không có", "GIAM10", "XAI20" });
            cboVoucher.SelectedIndex = 0;
            cboThongTinThuoc.Items.AddRange(_currentCart.CartDetails.Select(cd => cd.Product?.ProductName ?? "N/A").ToArray());
            UpdateDataGridView();
            UpdateSummary();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var row = dataGridView1.Rows[e.RowIndex];
                    var productName = row.Cells["ThongTinThuocColumn"].Value?.ToString();
                    if (!string.IsNullOrEmpty(productName))
                    {
                        cboThongTinThuoc.SelectedItem = productName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridView()
        {
            var cartDetails = _currentCart.CartDetails.ToList().Select(cd =>
            {
                string productName = cd.Product?.ProductName ?? "N/A";
                string unit = cd.Product?.Unit ?? "N/A";

                var productDetail = _context.ProductDetails.FirstOrDefault(pd => pd.ProductID == cd.ProductID);
                DateTime? expirationDate = productDetail?.ExpirationDate;

                return new CartDetailViewModel
                {
                    ThongTinThuoc = productName,
                    SoLuong = cd.Quantity,
                    DonViTinh = unit,
                    NgayHetHan = expirationDate,
                    ThanhTien = cd.Quantity * cd.UnitPrice
                };
            }).ToList();

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "ThongTinThuoc",
                Name = "ThongTinThuocColumn",
                Width = 200
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Số lượng",
                DataPropertyName = "SoLuong",
                Name = "SoLuongColumn",
                Width = 80
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Đơn vị tính",
                DataPropertyName = "DonViTinh",
                Name = "DonViTinhColumn",
                Width = 100
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ngày hết hạn",
                DataPropertyName = "NgayHetHan",
                Name = "NgayHetHanColumn",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Thành tiền",
                DataPropertyName = "ThanhTien",
                Name = "ThanhTienColumn",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
            });

            dataGridView1.DataSource = cartDetails;
        }

        private void UpdateSummary()
        {
            try
            {
                int totalQuantity = _currentCart.CartDetails.Sum(cd => cd.Quantity);
                decimal totalAmount = _currentCart.CartDetails.Sum(cd => cd.Quantity * cd.UnitPrice);
                decimal discount = 0m;
                string voucher = cboVoucher.SelectedItem?.ToString();
                if (voucher == "GIAM10") discount = totalAmount * 0.10m;
                else if (voucher == "GIAM20") discount = totalAmount * 0.20m;
                decimal tax = (totalAmount - discount) * 0.05m;
                decimal finalAmount = (totalAmount - discount) + tax;

                tBoSL.Text = totalQuantity.ToString();
                tBoTongtien.Text = totalAmount.ToString("C0");
                tBoThanhtien.Text = finalAmount.ToString("C0");

                _currentCart.TotalCartPrice = totalAmount;
                // Ghi chú: _context.UpdateCartTotal(_cartId) có thể không tồn tại, cần kiểm tra
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật summary: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (cboThongTinThuoc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string selectedProduct = cboThongTinThuoc.SelectedItem.ToString();
                var cartDetail = _currentCart.CartDetails.FirstOrDefault(cd => cd.Product != null && cd.Product.ProductName == selectedProduct);

                if (cartDetail != null)
                {
                    using (var transaction = _context.Database.BeginTransaction())
                    {
                        try
                        {
                            var dbCartDetail = _context.CartDetails
                                .FirstOrDefault(cd => cd.CartID == _cartId && cd.ProductID == cartDetail.ProductID);
                            if (dbCartDetail != null)
                            {
                                // Tăng lại StockQuantity trong ProductDetails
                                var productDetail = _context.ProductDetails.FirstOrDefault(pd => pd.ProductID == cartDetail.ProductID);
                                if (productDetail != null)
                                {
                                    productDetail.StockQuantity += cartDetail.Quantity;
                                    Console.WriteLine($"DEBUG - ProductID: {cartDetail.ProductID}, Increased Stock: +{cartDetail.Quantity}, New Stock: {productDetail.StockQuantity}");
                                }

                                _context.CartDetails.Remove(dbCartDetail);
                                _context.SaveChanges();
                            }

                            _currentCart.CartDetails.Remove(cartDetail);
                            cboThongTinThuoc.Items.Clear();
                            cboThongTinThuoc.Items.AddRange(_currentCart.CartDetails.Select(cd => cd.Product != null ? cd.Product.ProductName : "N/A").ToArray());
                            UpdateDataGridView();
                            UpdateSummary();

                            transaction.Commit();
                            MessageBox.Show("Xóa sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Lỗi khi xóa sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xuathoadon_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_currentCart.CartDetails.Any())
                {
                    MessageBox.Show("Giỏ hàng trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!_userId.HasValue)
                {
                    MessageBox.Show("UserID không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        // Tính toán tổng tiền
                        decimal totalAmount = _currentCart.CartDetails.Sum(cd => cd.Quantity * cd.UnitPrice);
                        decimal discount = 0m;
                        string voucher = cboVoucher.SelectedItem?.ToString();
                        if (voucher == "GIAM10") discount = totalAmount * 0.10m;
                        else if (voucher == "GIAM20") discount = totalAmount * 0.20m;
                        decimal tax = (totalAmount - discount) * 0.05m;
                        decimal finalAmount = (totalAmount - discount) + tax;

                        // Tạo và lưu Order
                        var order = new Order
                        {
                            CustomerID = _customerId,
                            UserID = _userId.Value,
                            OrderDate = DateTime.Now,
                            Amount = finalAmount,
                            Status = "Đã xử lý"
                        };
                        _context.Orders.Add(order);
                        _context.SaveChanges();

                        // Tạo và thêm OrderDetails
                        var orderDetails = _currentCart.CartDetails.Select(cd => new OrderDetail
                        {
                            OrderID = order.OrderID,
                            ProductID = cd.ProductID,
                            QuantityOrder = cd.Quantity,
                            UnitPrice = cd.UnitPrice
                        }).ToList();
                        _context.OrderDetails.AddRange(orderDetails);
                        _context.SaveChanges();

                        // Load dữ liệu
                        var orderDetailData = _context.OrderDetails
                            .Where(od => od.OrderID == order.OrderID)
                            .Include(od => od.Product)
                            .AsEnumerable()
                            .Select(od => new
                            {
                                ProductName = od.Product != null ? od.Product.ProductName : "N/A",
                                Quantity = od.QuantityOrder,
                                Unit = od.Product != null ? od.Product.Unit : "N/A",
                                UnitPrice = od.UnitPrice,
                                Total = od.QuantityOrder * od.UnitPrice
                            }).ToList();

                        if (!orderDetailData.Any())
                        {
                            MessageBox.Show("Dữ liệu orderDetailData trống!", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show($"Số lượng sản phẩm trong orderDetailData: {orderDetailData.Count}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Xóa giỏ hàng
                        var dbCart = _context.Carts.Include(c => c.CartDetails).FirstOrDefault(c => c.CartID == _cartId);
                        if (dbCart != null)
                        {
                            _context.CartDetails.RemoveRange(dbCart.CartDetails);
                            _context.Carts.Remove(dbCart);
                            _context.SaveChanges();
                        }

                        transaction.Commit();

                        // Mở form HoaDonChiTiet
                        var hoaDonChiTiet = new HoaDonChiTiet(
                            orderId: order.OrderID.ToString(),
                            customerId: _currentCart.Customer?.CustomerID,
                            orderDate: order.OrderDate,
                            totalQuantity: int.Parse(tBoSL.Text),
                            totalAmount: totalAmount,
                            discount: discount,
                            tax: tax,
                            finalAmount: finalAmount
                        );
                        hoaDonChiTiet.ShowDialog();

                        // Reset giao diện
                        _currentCart = null;
                        cboThongTinThuoc.Items.Clear();
                        cboThongTinThuoc.Enabled = false;
                        dataGridView1.Enabled = false;
                        btn_remove.Enabled = false;
                        btn_xuathoadon.Enabled = false;

                        _currentCart = new Cart
                        {
                            CartID = _cartId,
                            UserID = _userId.Value,
                            CustomerID = _customerId ?? 1,
                            TotalCartPrice = 0m
                        };
                        _context.Carts.Add(_currentCart);
                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Lỗi khi xuất hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_huydonhang_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentCart == null || !_currentCart.CartDetails.Any())
                {
                    MessageBox.Show("Giỏ hàng trống hoặc không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        // Duyệt qua tất cả CartDetails để hoàn lại stock
                        foreach (var cartDetail in _currentCart.CartDetails)
                        {
                            var productDetail = _context.ProductDetails.FirstOrDefault(pd => pd.ProductID == cartDetail.ProductID);
                            if (productDetail != null)
                            {
                                productDetail.StockQuantity += cartDetail.Quantity;
                                Console.WriteLine($"DEBUG - ProductID: {cartDetail.ProductID}, Increased Stock: +{cartDetail.Quantity}, New Stock: {productDetail.StockQuantity}");
                            }
                        }

                        // Xóa tất cả CartDetails và Cart
                        var dbCart = _context.Carts
                            .Include(c => c.CartDetails)
                            .FirstOrDefault(c => c.CartID == _cartId);
                        if (dbCart != null)
                        {
                            _context.CartDetails.RemoveRange(dbCart.CartDetails);
                            _context.Carts.Remove(dbCart);
                            _context.SaveChanges();
                        }

                        transaction.Commit();

                        // Reset giao diện
                        _currentCart = null;
                        cboThongTinThuoc.Items.Clear();
                        cboThongTinThuoc.Enabled = false;
                        dataGridView1.Enabled = false;
                        btn_remove.Enabled = false;
                        btn_xuathoadon.Enabled = false;

                        MessageBox.Show("Đã hủy giỏ hàng", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Lỗi khi hủy giỏ hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSDTKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string phoneNumber = tbSDTKH.Text.Trim();

                if (string.IsNullOrEmpty(phoneNumber))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var context = new EFDbContext())
                {
                    var customer = context.Customers.FirstOrDefault(c => c.PhoneNumber == phoneNumber);

                    if (customer != null)
                    {
                        // Khách hàng cũ
                        _customerId = customer.CustomerID;
                        _currentCart.CustomerID = customer.CustomerID;
                        _currentCart.Customer = customer;

                        MessageBox.Show($"Đã tìm thấy khách hàng: {customer.CustomerName}", "Thông tin khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Khách hàng mới
                        _customerId = null;
                        _currentCart.CustomerID = null;
                        _currentCart.Customer = null;

                        MessageBox.Show("Không tìm thấy khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }

                    context.SaveChanges();
                }
            }
        }

        private void cboThongTinThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể hiển thị thông tin sản phẩm
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboThongTinThuoc_SelectedIndexChanged(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            tbSDTKH.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            cboPhuongthuc.DroppedDown = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            cboVoucher.DroppedDown = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void cboPhuongthuc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void tBoSL_TextChanged(object sender, EventArgs e)
        {
        }
    }

    public class CartDetailViewModel
    {
        public string ThongTinThuoc { get; set; }
        public int SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public decimal ThanhTien { get; set; }
    }
}