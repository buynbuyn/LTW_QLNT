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
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var popup = new KhachHangPopupForm();
            popup.ShowDialog();
            LoadKhachHang(); // reload danh sách sau khi thêm
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                int id = (int)dgvKhachHang.CurrentRow.Cells["CustomerID"].Value;
                var popup = new KhachHangPopupForm(id); // mở tab sửa
                popup.ShowDialog();
                LoadKhachHang(); // reload danh sách sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa.", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                int id = (int)dgvKhachHang.CurrentRow.Cells["CustomerID"].Value;

                if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var context = new EFDbContext())
                    {
                        var kh = context.Customers.Find(id);
                        if (kh != null)
                        {
                            context.Customers.Remove(kh);
                            context.SaveChanges();
                            LoadKhachHang();
                            MessageBox.Show("Đã xóa khách hàng.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo");
            }
        }
    }
}
