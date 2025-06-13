using Microsoft.EntityFrameworkCore;
using QLNT.Data;
using System;
using System.Linq;
using System.Windows.Forms;
// using System.Drawing; // Không cần thiết nếu không tự vẽ controls

namespace QLNT
{
    public partial class OrderDetailForm : Form
    {
        private readonly int _orderId;
        // KHÔNG CẦN KHAI BÁO LẠI CÁC CONTROLS Ở ĐÂY NỮA
        // VÌ InitializeComponent() (trong Designer.cs) ĐÃ LÀM ĐIỀU ĐÓ.
        // private DataGridView dgvDetails; // XÓA DÒNG NÀY
        // private Label lblOrderInfo; // XÓA DÒNG NÀY

        public OrderDetailForm(int orderId)
        {
            _orderId = orderId;
            InitializeComponent(); // Đây là nơi các controls được khởi tạo từ Designer.cs
            // KHÔNG CẦN GỌI InitializeLayout() NỮA
            this.Text = "Chi tiết hóa đơn #" + _orderId; // Đặt tiêu đề form
        }

        private void OrderDetailForm_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    // Lấy thông tin tổng quát của hóa đơn để hiển thị trên Label
                    var order = db.Orders
                                  .Include("Customer") // Bao gồm Customer để truy cập CustomerName, PhoneNumber
                                  .Include("User")     // Bao gồm User để truy cập FullName
                                  .FirstOrDefault(o => o.OrderID == _orderId);

                    if (order != null)
                    {
                        lblOrderInfo.Text = $"Chi tiết hóa đơn #{_orderId}\n" +
                                            $"Khách hàng: {order.Customer?.CustomerName ?? "N/A"} - SĐT: {order.Customer?.PhoneNumber ?? "N/A"}\n" +
                                            $"Nhân viên: {order.User?.FullName ?? "N/A"}\n" +
                                            $"Ngày lập: {order.OrderDate:dd/MM/yyyy HH:mm}\n" +
                                            $"Tổng tiền: {order.Amount:C0}"; // C0: Currency format, 0 thập phân
                        lblOrderInfo.AutoSize = true; // Đảm bảo label tự động điều chỉnh kích thước theo nội dung
                    }
                    else
                    {
                        lblOrderInfo.Text = $"Không tìm thấy hóa đơn có mã: {_orderId}";
                    }

                    // Lấy thông tin chi tiết các sản phẩm trong đơn hàng
                    var orderDetails = db.OrderDetails
                        .Where(od => od.OrderID == _orderId)
                        .Select(od => new
                        {
                            od.Product.ProductName,
                            od.QuantityOrder,
                            od.UnitPrice,
                            Total = od.QuantityOrder * od.UnitPrice,
                            od.PaymentMethod
                        })
                        .ToList();

                    dgvDetails.DataSource = orderDetails;

                    // Tùy chỉnh tiêu đề và định dạng cột sau khi gán DataSource
                    if (dgvDetails.Columns.Contains("ProductName")) dgvDetails.Columns["ProductName"].HeaderText = "Tên Thuốc";
                    if (dgvDetails.Columns.Contains("QuantityOrder")) dgvDetails.Columns["QuantityOrder"].HeaderText = "Số Lượng";
                    if (dgvDetails.Columns.Contains("UnitPrice"))
                    {
                        dgvDetails.Columns["UnitPrice"].HeaderText = "Đơn Giá";
                        dgvDetails.Columns["UnitPrice"].DefaultCellStyle.Format = "C0";
                    }
                    if (dgvDetails.Columns.Contains("Total"))
                    {
                        dgvDetails.Columns["Total"].HeaderText = "Thành Tiền";
                        dgvDetails.Columns["Total"].DefaultCellStyle.Format = "C0";
                    }
                    if (dgvDetails.Columns.Contains("PaymentMethod")) dgvDetails.Columns["PaymentMethod"].HeaderText = "Phương Thức TT";

                    dgvDetails.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải chi tiết đơn hàng: {ex.Message}\nChi tiết: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}