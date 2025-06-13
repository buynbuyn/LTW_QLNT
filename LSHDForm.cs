using QLNT.Data;
using QLNT.models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
// using System.Drawing; // Không cần thiết nếu không tự vẽ controls

namespace QLNT
{
    public partial class LSHDForm : Form
    {
        // KHÔNG CẦN KHAI BÁO LẠI CÁC CONTROLS Ở ĐÂY NỮA
        // VÌ InitializeComponent() (trong Designer.cs) ĐÃ LÀM ĐIỀU ĐÓ.
        // private DataGridView dgvOrders; // XÓA DÒNG NÀY
        // private Label lblTitle; // XÓA DÒNG NÀY
        // ... và các controls khác

        public LSHDForm()
        {
            InitializeComponent(); // Đây là nơi các controls được khởi tạo từ Designer.cs
            // KHÔNG CẦN GỌI InitializeLayout() NỮA
        }

        private void LSHDForm_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            using (var db = new EFDbContext())
            {
                // Lấy danh sách hóa đơn và các thông tin liên quan
                var orderList = db.Orders
                                  .Select(o => new
                                  {
                                      o.OrderID,
                                      CustomerInfo = o.Customer.CustomerName + (o.Customer.PhoneNumber != null ? " - " + o.Customer.PhoneNumber : ""), // Kết hợp tên và SĐT
                                      StaffInfo = o.User.FullName, // Tên nhân viên
                                      // Để hiển thị danh sách thuốc, bạn cần một cách để aggregate nó.
                                      // Đây là một ví dụ đơn giản sử dụng string.Join, nhưng nó có thể dài.
                                      // Tùy thuộc vào cách bạn muốn hiển thị (ví dụ: chỉ tên thuốc, hoặc số lượng), bạn có thể điều chỉnh.
                                      MedicineList = string.Join(", ", o.OrderDetails.Select(od => od.Product.ProductName)),
                                      o.OrderDate,
                                      o.Amount,
                                      o.Status
                                  })
                                  .ToList();

                dgvOrders.DataSource = orderList;

                // Tùy chỉnh tiêu đề và định dạng cột sau khi gán DataSource
                if (dgvOrders.Columns.Contains("OrderID")) dgvOrders.Columns["OrderID"].HeaderText = "Mã Hóa Đơn";
                if (dgvOrders.Columns.Contains("CustomerInfo")) dgvOrders.Columns["CustomerInfo"].HeaderText = "Thông tin khách hàng";
                if (dgvOrders.Columns.Contains("StaffInfo")) dgvOrders.Columns["StaffInfo"].HeaderText = "Thông tin nhân viên";
                if (dgvOrders.Columns.Contains("MedicineList")) dgvOrders.Columns["MedicineList"].HeaderText = "Danh sách thuốc";
                if (dgvOrders.Columns.Contains("OrderDate")) dgvOrders.Columns["OrderDate"].HeaderText = "Ngày lập";
                if (dgvOrders.Columns.Contains("Amount"))
                {
                    dgvOrders.Columns["Amount"].HeaderText = "Tổng tiền";
                    dgvOrders.Columns["Amount"].DefaultCellStyle.Format = "C0"; // Định dạng tiền tệ không dấu thập phân
                }
                if (dgvOrders.Columns.Contains("Status")) dgvOrders.Columns["Status"].HeaderText = "Trạng thái";

                dgvOrders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Đảm bảo cột "OrderID" có dữ liệu và không phải là null
                if (dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value != null)
                {
                    int orderId = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value);
                    // Giả định bạn có một form OrderDetailForm để hiển thị chi tiết hóa đơn
                    var form = new OrderDetailForm(orderId);
                    form.ShowDialog();
                    LoadOrderData(); // Tải lại dữ liệu sau khi đóng OrderDetailForm (nếu có thay đổi)
                }
            }
        }

        // Event handler cho nút "Tìm hóa đơn"
        private void BtnFindInvoice_Click(object sender, EventArgs e)
        {
            // Triển khai logic tìm kiếm hóa đơn ở đây
            // Bạn có thể mở một form tìm kiếm hoặc thêm các ô lọc vào form này
            MessageBox.Show("Chức năng 'Tìm hóa đơn' sẽ được triển khai tại đây.");
        }

        // Event handler cho nút "Xóa hóa đơn"
        private void BtnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInvoiceIDToDelete.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã hóa đơn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(txtInvoiceIDToDelete.Text, out int orderIdToDelete))
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa hóa đơn có Mã Hóa Đơn: {orderIdToDelete} không?\nLưu ý: Thao tác này sẽ xóa vĩnh viễn hóa đơn và các chi tiết liên quan!", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var db = new EFDbContext())
                    {
                        var orderToDelete = db.Orders.Find(orderIdToDelete);
                        if (orderToDelete != null)
                        {
                            // Xóa các chi tiết hóa đơn liên quan trước để tránh lỗi ràng buộc khóa ngoại
                            var orderDetails = db.OrderDetails.Where(od => od.OrderID == orderIdToDelete).ToList();
                            db.OrderDetails.RemoveRange(orderDetails);

                            db.Orders.Remove(orderToDelete);
                            db.SaveChanges();
                            MessageBox.Show("Hóa đơn đã được xóa thành công.");
                            LoadOrderData(); // Tải lại dữ liệu sau khi xóa
                            txtInvoiceIDToDelete.Clear(); // Xóa nội dung textbox
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn với mã đã nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi xóa hóa đơn: {ex.Message}\nChi tiết: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler cho nút "Hủy" trong panel xóa
        private void BtnCancelDelete_Click(object sender, EventArgs e)
        {
            txtInvoiceIDToDelete.Clear();
            // Bạn có thể thêm các hành động khác ở đây, ví dụ: đóng panel xóa nếu nó có thể đóng/mở
            // MessageBox.Show("Hành động xóa đã bị hủy."); // Có thể bỏ thông báo này nếu không cần thiết
        }
    }
}