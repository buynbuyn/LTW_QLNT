using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNT.Data;
using QLNT.models;
using Microsoft.EntityFrameworkCore;

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
                // Kiểm tra và cập nhật _userId khi form load
                int? previousUserId = _userId;
                _userId = Utility.UserID;

                if (!_userId.HasValue)
                {
                    MessageBox.Show("UserID không hợp lệ hoặc chưa đăng nhập! Vui lòng đăng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboThongTinThuoc.Enabled = false;
                    dataGridView1.Enabled = false;
                    btn_remove.Enabled = false;
                    btn_xuathoadon.Enabled = false;
                    return;
                }

                // Kiểm tra nếu đổi tài khoản, reset giỏ hàng
                if (previousUserId != _userId)
                {
                    _currentCart = null;
                    _cartId = _userId.Value;
                }
                else
                {
                    _cartId = _userId.Value;
                }

                var cartCount = _context.Carts.Count();
                var cartDetailCount = _context.CartDetails.Count();
                var matchingCarts = _context.Carts.Where(c => c.CartID == _cartId && c.UserID == _userId).Count();
                MessageBox.Show($"Carts: {cartCount}, CartDetails: {cartDetailCount}\nMatching Carts: {matchingCarts}\nCartID: {_cartId}\nUserID: {_userId}\nConnection: {_context.Database.GetConnectionString()}", "Debug DB");

                using (var context = new EFDbContext())
                {
                    _currentCart = context.Carts
                        .Include(c => c.Customer)
                        .Include(c => c.CartDetails)
                        .ThenInclude(cd => cd.Product)
                        .AsNoTracking()
                        .FirstOrDefault(c => c.CartID == _cartId && c.UserID == _userId.Value);

                    if (_currentCart == null)
                    {
                        _currentCart = new Cart
                        {
                            CartID = _cartId,
                            UserID = _userId.Value,
                            CustomerID = _customerId ?? 1,
                            TotalCartPrice = 0m
                        };
                        context.Carts.Add(_currentCart);
                        context.SaveChanges();
                        MessageBox.Show($"Tạo mới giỏ hàng với CartID {_cartId} cho UserID {_userId.Value}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _currentCart = context.Carts
                            .Include(c => c.Customer)
                            .Include(c => c.CartDetails)
                            .ThenInclude(cd => cd.Product)
                            .FirstOrDefault(c => c.CartID == _cartId && c.UserID == _userId.Value);
                    }

                    if (!_currentCart.CartDetails.Any())
                    {
                        MessageBox.Show($"Giỏ hàng {_cartId} không có sản phẩm cho UserID {_userId.Value}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboThongTinThuoc.Enabled = false;
                        dataGridView1.Enabled = false;
                        btn_remove.Enabled = false;
                        btn_xuathoadon.Enabled = false;
                        return;
                    }
                }

                // Load dữ liệu vào memory trước khi dùng null check
                var cartDetails = _currentCart.CartDetails.ToList();
                tbSDTKH.Text = _currentCart.Customer != null ? _currentCart.Customer.PhoneNumber : "N/A";
                cboPhuongthuc.Items.AddRange(new string[] { "Cash", "Chuyển khoản", "Thẻ tín dụng" });
                cboPhuongthuc.SelectedIndex = 0;
                cboVoucher.Items.AddRange(new string[] { "Không có", "GIAM10", "GIAM20" });
                cboVoucher.SelectedIndex = 0;

                // Sử dụng dữ liệu đã load
                cboThongTinThuoc.Items.AddRange(cartDetails.Select(cd => cd.Product != null ? cd.Product.ProductName : "N/A").ToArray());
                UpdateDataGridView();
                UpdateSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                        // Tạo và lưu Order trước
                        var order = new Order
                        {
                            CustomerID = _currentCart.CustomerID ?? _customerId ?? 1,
                            UserID = _userId.Value,
                            OrderDate = DateTime.Now,
                            Amount = finalAmount,
                            Status = "Đã xử lý"
                        };
                        _context.Orders.Add(order);
                        _context.SaveChanges(); // Lưu để lấy OrderID

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

                        // === Trừ số lượng tồn kho theo ProductID ===
                        foreach (var cd in _currentCart.CartDetails)
                        {
                            var productDetail = _context.ProductDetails.FirstOrDefault(p => p.ProductID == cd.ProductID);
                            var productInfo = _context.Products.FirstOrDefault(p => p.ProductID == cd.ProductID); // để lấy tên

                            if (productDetail != null)
                            {
                                if (productDetail.StockQuantity >= cd.Quantity)
                                {
                                    productDetail.StockQuantity -= cd.Quantity;
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show(
                                        $"Sản phẩm {(productInfo?.ProductName ?? "Không xác định")} không đủ hàng trong kho!\n" +
                                        $"Tồn kho: {productDetail.StockQuantity}, Yêu cầu: {cd.Quantity}",
                                        "Lỗi kho hàng",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                                    return;
                                }
                            }
                        }
                        _context.SaveChanges();


                        // Load dữ liệu vào memory để xử lý null
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

                        // Debug: Kiểm tra dữ liệu
                        if (!orderDetailData.Any())
                        {
                            MessageBox.Show("Dữ liệu orderDetailData trống!", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show($"Số lượng sản phẩm trong orderDetailData: {orderDetailData.Count}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Xóa giỏ hàng
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

                        // Mở form HoaDonChiTiet
                        var hoaDonChiTiet = new HoaDonChiTiet(
                            orderId: order.OrderID.ToString(),
                            customerName: _currentCart.Customer != null ? _currentCart.Customer.CustomerName : "N/A",
                            phone: tbSDTKH.Text,
                            email: _currentCart.Customer != null ? _currentCart.Customer.Email : "N/A",
                            orderDate: order.OrderDate,
                            totalQuantity: int.Parse(tBoSL.Text),
                            totalAmount: totalAmount,
                            discount: discount,
                            tax: tax,
                            finalAmount: finalAmount
                        );
                        hoaDonChiTiet.ShowDialog();

                        // Reset giao diện và tạo lại giỏ hàng trống
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
                if (_currentCart != null)
                {
                    using (var transaction = _context.Database.BeginTransaction())
                    {
                        try
                        {
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

                            _currentCart = null;
                            cboThongTinThuoc.Items.Clear();
                            cboThongTinThuoc.Enabled = false;
                            dataGridView1.Enabled = false;
                            btn_remove.Enabled = false;
                            btn_xuathoadon.Enabled = false;

                            MessageBox.Show("Đã hủy giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Lỗi khi hủy giỏ hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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