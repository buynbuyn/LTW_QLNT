using QLNT.Data;
using QLNT.models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLNT
{
    public partial class KhachHangForm : Form
    {
        public KhachHangForm()
        {
            InitializeComponent();
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            using (var context = new EFDbContext())
            {
                var ds = context.Customers
                    .Select(c => new
                    {
                        c.CustomerID,
                        c.CustomerName,
                        c.Gender,
                        c.Address,
                        c.PhoneNumber,
                        c.Email
                    })
                    .ToList();

                dgvKhachHang.DataSource = ds;
                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                AddActionButtons(); // Thêm nút Sửa và Xóa
            }
        }

        private void AddActionButtons()
        {
            if (dgvKhachHang.Columns["btnEdit"] == null)
            {
                var btnEdit = new DataGridViewButtonColumn
                {
                    HeaderText = "",
                    Text = "Sửa",
                    Name = "btnEdit",
                    UseColumnTextForButtonValue = true
                };
                dgvKhachHang.Columns.Add(btnEdit);
            }

            if (dgvKhachHang.Columns["btnDelete"] == null)
            {
                var btnDelete = new DataGridViewButtonColumn
                {
                    HeaderText = "",
                    Text = "Xóa",
                    Name = "btnDelete",
                    UseColumnTextForButtonValue = true
                };
                dgvKhachHang.Columns.Add(btnDelete);
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // 🛡️ bảo vệ khỏi lỗi click tiêu đề hoặc row header

            var columnName = dgvKhachHang.Columns[e.ColumnIndex].Name;
            int id = Convert.ToInt32(dgvKhachHang.Rows[e.RowIndex].Cells["CustomerID"].Value);

            if (columnName == "btnEdit")
            {
                var form = new SuaKhachHangForm(id);
                form.ShowDialog();
                LoadKhachHang();
            }
            else if (columnName == "btnDelete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var context = new EFDbContext())
                    {
                        var kh = context.Customers.Find(id);
                        if (kh != null)
                        {
                            context.Customers.Remove(kh);
                            context.SaveChanges();
                            MessageBox.Show("Đã xóa khách hàng.");
                            LoadKhachHang();
                        }
                    }
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            using (var context = new EFDbContext())
            {
                var result = context.Customers
                    .Where(c =>
                        c.CustomerName.Contains(keyword) ||
                        c.PhoneNumber.Contains(keyword) ||
                        c.Email.Contains(keyword))
                    .Select(c => new
                    {
                        c.CustomerID,
                        c.CustomerName,
                        c.Gender,
                        c.Address,
                        c.PhoneNumber,
                        c.Email
                    })
                    .ToList();

                dgvKhachHang.DataSource = result;
                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                AddActionButtons();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new ThemKhachHangForm();
            form.ShowDialog();
            LoadKhachHang();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không dùng, bạn có thể bỏ qua hoặc để trống
        }
    }
}
