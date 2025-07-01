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
            this.Load += LSHDForm_Load;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            btnSearch.Click += BtnSearch_Click;
            btnFilter.Click += BtnFilter_Click;
        }

        private void LSHDForm_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        private void LoadOrderData(Func<Order, bool> filter = null)
        {
            using (var db = new EFDbContext())
            {
                var query = db.Orders.AsEnumerable(); // Dùng AsEnumerable để dùng được hàm filter C#

                if (filter != null)
                    query = query.Where(filter);

                var orderList = query
                    .Select(o => new
                    {
                        o.OrderID,
                        CustomerInfo = o.Customer.CustomerName + (o.Customer.PhoneNumber != null ? " - " + o.Customer.PhoneNumber : ""),
                        StaffInfo = o.User.FullName,
                        MedicineList = string.Join(", ", o.OrderDetails.Select(od => od.Product.ProductName)),
                        o.OrderDate,
                        o.Amount,
                        o.Status
                    })
                    .ToList();

                dgvOrders.DataSource = null;
                dgvOrders.Columns.Clear();
                dgvOrders.DataSource = orderList;

                AddDeleteButton();

                dgvOrders.Columns["OrderID"].HeaderText = "Mã Hóa Đơn";
                dgvOrders.Columns["CustomerInfo"].HeaderText = "Khách hàng";
                dgvOrders.Columns["StaffInfo"].HeaderText = "Nhân viên";
                dgvOrders.Columns["MedicineList"].HeaderText = "Thuốc";
                dgvOrders.Columns["OrderDate"].HeaderText = "Ngày lập";
                dgvOrders.Columns["Amount"].HeaderText = "Tổng tiền";
                dgvOrders.Columns["Amount"].DefaultCellStyle.Format = "C0";
                dgvOrders.Columns["Status"].HeaderText = "Trạng thái";

                dgvOrders.AutoResizeColumns();
            }
        }

        private void AddDeleteButton()
        {
            if (!dgvOrders.Columns.Contains("Delete"))
            {
                var btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Delete";
                btnDelete.HeaderText = "Xóa";
                btnDelete.Text = "Xóa";
                btnDelete.UseColumnTextForButtonValue = true;
                dgvOrders.Columns.Add(btnDelete);
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var colName = dgvOrders.Columns[e.ColumnIndex].Name;

            if (colName == "Delete")
            {
                int orderId = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value);

                var confirm = MessageBox.Show($"Xóa hóa đơn {orderId}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    using (var db = new EFDbContext())
                    {
                        var order = db.Orders.Find(orderId);
                        if (order != null)
                        {
                            db.OrderDetails.RemoveRange(order.OrderDetails);
                            db.Orders.Remove(order);
                            db.SaveChanges();
                        }
                    }

                    LoadOrderData();
                }
            }
            else
            {
                // Xử lý xem chi tiết khi double-click
                if (dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value != null)
                {
                    int orderId = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value);
                    var form = new OrderDetailForm(orderId);
                    form.ShowDialog();
                    LoadOrderData();
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadOrderData();
                return;
            }

            LoadOrderData(o => o.Customer.CustomerName.ToLower().Contains(keyword));
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            int year = cbYear.SelectedItem != null ? Convert.ToInt32(cbYear.SelectedItem) : 0;
            int month = cbMonth.SelectedItem != null ? Convert.ToInt32(cbMonth.SelectedItem) : 0;
            int day = cbDay.SelectedItem != null ? Convert.ToInt32(cbDay.SelectedItem) : 0;

            LoadOrderData(o =>
            {
                var d = o.OrderDate;
                bool match = true;
                if (year > 0) match &= d.Year == year;
                if (month > 0) match &= d.Month == month;
                if (day > 0) match &= d.Day == day;
                return match;
            });
        }
    }
}