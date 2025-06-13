using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Printing;
using QLNT.Data;
using Microsoft.EntityFrameworkCore;

namespace QLNT
{
    public partial class HoaDonChiTiet : Form
    {
        private readonly EFDbContext _context;
        private PrintDocument printDocument;
        private int _orderId;

        public HoaDonChiTiet(string orderId, string customerName, string phone, string email, DateTime orderDate,
            int totalQuantity, decimal totalAmount, decimal discount, decimal tax, decimal finalAmount)
        {
            InitializeComponent();
            _context = new EFDbContext();
            _orderId = int.Parse(orderId); // Chuyển đổi orderId thành int

            // Gán dữ liệu với kiểm tra null
            textBox1.Text = string.IsNullOrEmpty(orderId) ? "N/A" : orderId; // Mã hóa đơn
            textBox2.Text = string.IsNullOrEmpty(customerName) ? "N/A" : customerName; // Họ tên khách hàng
            textBox3.Text = string.IsNullOrEmpty(email) ? "N/A" : email; // Email khách hàng
            textBox4.Text = string.IsNullOrEmpty(phone) ? "N/A" : phone; // SĐT khách hàng
            textBox10.Text = orderDate != DateTime.MinValue ? orderDate.ToString("dd/MM/yyyy") : "N/A"; // Ngày

            // Cập nhật tổng hợp
            textBox5.Text = totalQuantity > 0 ? totalQuantity.ToString() : "0"; // Tổng số lượng
            textBox6.Text = totalAmount >= 0 ? totalAmount.ToString("C0") : "0,00 đ"; // Tổng tiền
            textBox7.Text = discount >= 0 ? discount.ToString("C0") : "0,00 đ"; // Giảm giá
            textBox8.Text = tax >= 0 ? tax.ToString("C0") : "0,00 đ"; // Thuế
            textBox9.Text = finalAmount >= 0 ? finalAmount.ToString("C0") : "0,00 đ"; // Thành tiền

            // Cấu hình và gắn dữ liệu từ OrderDetails vào DataGridView
            LoadOrderDetails();

            // Khởi tạo PrintDocument
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void LoadOrderDetails()
        {
            try
            {
                var orderDetails = _context.OrderDetails
                    .Include(od => od.Product)
                    .Where(od => od.OrderID == _orderId)
                    .Select(od => new
                    {
                        ProductName = od.Product != null ? od.Product.ProductName : "N/A",
                        Quantity = od.QuantityOrder,
                        Unit = od.Product != null ? od.Product.Unit : "N/A",
                        UnitPrice = od.UnitPrice,
                        Total = od.QuantityOrder * od.UnitPrice
                    }).ToList();

                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Tên sản phẩm",
                    DataPropertyName = "ProductName",
                    Width = 300
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Số lượng",
                    DataPropertyName = "Quantity",
                    Width = 100
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Đơn vị tính",
                    DataPropertyName = "Unit",
                    Width = 150
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Đơn giá",
                    DataPropertyName = "UnitPrice",
                    Width = 150,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Thành tiền",
                    DataPropertyName = "Total",
                    Width = 150,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
                });

                dataGridView1.DataSource = orderDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu OrderDetails: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.DataSource = new List<object>(); // Gán nguồn trống để tránh crash
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Đóng form khi click vào label1 (giả sử là nút "Đóng")
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // In hóa đơn khi click vào label3 (giả sử là nút "In")
            try
            {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
                {
                    Document = printDocument
                };
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi in: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hiển thị thông tin chi tiết sản phẩm khi click vào dòng
            try
            {
                if (e.RowIndex >= 0)
                {
                    var row = dataGridView1.Rows[e.RowIndex];
                    string productName = row.Cells["ProductName"].Value?.ToString() ?? "N/A";
                    int quantity = (int)row.Cells["Quantity"].Value;
                    string unit = row.Cells["Unit"].Value?.ToString() ?? "N/A";
                    decimal unitPrice = (decimal)row.Cells["UnitPrice"].Value;
                    decimal total = (decimal)row.Cells["Total"].Value;

                    MessageBox.Show($"Thông tin sản phẩm:\nTên: {productName}\nSố lượng: {quantity}\nĐơn vị: {unit}\nĐơn giá: {unitPrice:C0}\nThành tiền: {total:C0}",
                        "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Logic in hóa đơn
            string printText = $"Hóa đơn #{textBox1.Text}\n" +
                              $"Khách hàng: {textBox2.Text}\n" +
                              $"SĐT: {textBox4.Text}\n" +
                              $"Email: {textBox3.Text}\n" +
                              $"Ngày: {textBox10.Text}\n" +
                              "\nDanh sách sản phẩm:\n";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                printText += $"{row.Cells["ProductName"].Value} | {row.Cells["Quantity"].Value} | {row.Cells["Unit"].Value} | {row.Cells["UnitPrice"].Value} | {row.Cells["Total"].Value}\n";
            }

            printText += $"\nTổng số lượng: {textBox5.Text}\n" +
                         $"Tổng tiền: {textBox6.Text}\n" +
                         $"Giảm giá: {textBox7.Text}\n" +
                         $"Thuế: {textBox8.Text}\n" +
                         $"Thành tiền: {textBox9.Text}";

            using (var font = new Font("Arial", 12))
            {
                e.Graphics.DrawString(printText, font, Brushes.Black, new PointF(100, 100));
            }
        }
    }
}