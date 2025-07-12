using QLNT.Data;
using QLNT.models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLNT
{
    public partial class LSHDForm : Form
    {
        public LSHDForm()
        {
            InitializeComponent();
            dgvOrders.CellContentClick += dgvOrders_CellContentClick; // Gắn sự kiện
            this.Load += LSHDForm_Load;

            // Gắn sự kiện tìm kiếm
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void LSHDForm_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            using (var db = new EFDbContext())
            {
                var orderList = db.Orders
                                  .Select(o => new
                                  {
                                      o.OrderID,
                                      CustomerInfo = o.Customer.CustomerName +
                                                     (o.Customer.PhoneNumber != null ? " - " + o.Customer.PhoneNumber : ""),
                                      StaffInfo = o.User.FullName,
                                      MedicineList = string.Join(", ", o.OrderDetails.Select(od => od.Product.ProductName)),
                                      o.OrderDate,
                                      o.Amount,
                                      o.Status
                                  })
                                  .ToList();

                dgvOrders.DataSource = orderList;

                // Đặt lại header các cột
                if (dgvOrders.Columns.Contains("OrderID")) dgvOrders.Columns["OrderID"].HeaderText = "Mã Hóa Đơn";
                if (dgvOrders.Columns.Contains("CustomerInfo")) dgvOrders.Columns["CustomerInfo"].HeaderText = "Thông tin khách hàng";
                if (dgvOrders.Columns.Contains("StaffInfo")) dgvOrders.Columns["StaffInfo"].HeaderText = "Thông tin nhân viên";
                if (dgvOrders.Columns.Contains("MedicineList")) dgvOrders.Columns["MedicineList"].HeaderText = "Danh sách thuốc";
                if (dgvOrders.Columns.Contains("OrderDate")) dgvOrders.Columns["OrderDate"].HeaderText = "Ngày lập";
                if (dgvOrders.Columns.Contains("Amount"))
                {
                    dgvOrders.Columns["Amount"].HeaderText = "Tổng tiền";
                    dgvOrders.Columns["Amount"].DefaultCellStyle.Format = "C0";
                }
                if (dgvOrders.Columns.Contains("Status")) dgvOrders.Columns["Status"].HeaderText = "Trạng thái";

                // Thêm nút Sửa
                if (!dgvOrders.Columns.Contains("EditButton"))
                {
                    var editBtn = new DataGridViewButtonColumn();
                    editBtn.Name = "EditButton";
                    editBtn.HeaderText = "";
                    editBtn.Text = "xem";
                    editBtn.UseColumnTextForButtonValue = true;
                    dgvOrders.Columns.Add(editBtn);
                }

                // Thêm nút Xóa
                if (!dgvOrders.Columns.Contains("DeleteButton"))
                {
                    var deleteBtn = new DataGridViewButtonColumn();
                    deleteBtn.Name = "DeleteButton";
                    deleteBtn.HeaderText = "";
                    deleteBtn.Text = "Xóa";
                    deleteBtn.UseColumnTextForButtonValue = true;
                    dgvOrders.Columns.Add(deleteBtn);
                }

                dgvOrders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            using (var db = new EFDbContext())
            {
                var orderList = db.Orders
                                  .Select(o => new
                                  {
                                      o.OrderID,
                                      CustomerInfo = o.Customer.CustomerName +
                                                     (o.Customer.PhoneNumber != null ? " - " + o.Customer.PhoneNumber : ""),
                                      StaffInfo = o.User.FullName,
                                      MedicineList = string.Join(", ", o.OrderDetails.Select(od => od.Product.ProductName)),
                                      o.OrderDate,
                                      o.Amount,
                                      o.Status
                                  })
                                  .ToList()
                                  .Where(o =>
                                      o.OrderID.ToString().Contains(searchText) ||
                                      o.CustomerInfo.ToLower().Contains(searchText) ||
                                      o.StaffInfo.ToLower().Contains(searchText)
                                  )
                                  .ToList();

                dgvOrders.DataSource = orderList;

                // Cập nhật lại header và button columns
                UpdateDataGridViewColumns();
            }
        }

        private void UpdateDataGridViewColumns()
        {
            // Đặt lại header các cột
            if (dgvOrders.Columns.Contains("OrderID")) dgvOrders.Columns["OrderID"].HeaderText = "Mã Hóa Đơn";
            if (dgvOrders.Columns.Contains("CustomerInfo")) dgvOrders.Columns["CustomerInfo"].HeaderText = "Thông tin khách hàng";
            if (dgvOrders.Columns.Contains("StaffInfo")) dgvOrders.Columns["StaffInfo"].HeaderText = "Thông tin nhân viên";
            if (dgvOrders.Columns.Contains("MedicineList")) dgvOrders.Columns["MedicineList"].HeaderText = "Danh sách thuốc";
            if (dgvOrders.Columns.Contains("OrderDate")) dgvOrders.Columns["OrderDate"].HeaderText = "Ngày lập";
            if (dgvOrders.Columns.Contains("Amount"))
            {
                dgvOrders.Columns["Amount"].HeaderText = "Tổng tiền";
                dgvOrders.Columns["Amount"].DefaultCellStyle.Format = "C0";
            }
            if (dgvOrders.Columns.Contains("Status")) dgvOrders.Columns["Status"].HeaderText = "Trạng thái";

            // Thêm nút Sửa nếu chưa có
            if (!dgvOrders.Columns.Contains("EditButton"))
            {
                var editBtn = new DataGridViewButtonColumn();
                editBtn.Name = "EditButton";
                editBtn.HeaderText = "";
                editBtn.Text = "xem";
                editBtn.UseColumnTextForButtonValue = true;
                dgvOrders.Columns.Add(editBtn);
            }

            // Thêm nút Xóa nếu chưa có
            if (!dgvOrders.Columns.Contains("DeleteButton"))
            {
                var deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.Name = "DeleteButton";
                deleteBtn.HeaderText = "";
                deleteBtn.Text = "Xóa";
                deleteBtn.UseColumnTextForButtonValue = true;
                dgvOrders.Columns.Add(deleteBtn);
            }

            dgvOrders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var orderIdObj = dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value;
                if (orderIdObj == null) return;

                int orderId = Convert.ToInt32(orderIdObj);

                if (dgvOrders.Columns[e.ColumnIndex].Name == "EditButton")
                {
                    // Mở form chi tiết (sửa)
                    var form = new OrderDetailForm(orderId);
                    form.ShowDialog();
                    LoadOrderData();
                }
                else if (dgvOrders.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    DialogResult confirm = MessageBox.Show($"Bạn có chắc muốn xóa hóa đơn {orderId}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        using (var db = new EFDbContext())
                        {
                            var order = db.Orders.Find(orderId);
                            if (order != null)
                            {
                                var orderDetails = db.OrderDetails.Where(od => od.OrderID == orderId).ToList();
                                db.OrderDetails.RemoveRange(orderDetails);
                                db.Orders.Remove(order);
                                db.SaveChanges();
                                MessageBox.Show("Xóa thành công!");
                                LoadOrderData();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy hóa đơn cần xóa.");
                            }
                        }
                    }
                }
            }
        }
    }
}