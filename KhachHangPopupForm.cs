using QLNT.Data;
using QLNT.models;
using System;
using System.Windows.Forms;

namespace QLNT
{
    public partial class KhachHangPopupForm : Form
    {
        private int? customerId = null;
        private bool isLoaded = false; // để tránh trigger SelectedIndexChanged khi chưa sẵn sàng

        // Constructor mặc định (dùng cho thêm khách hàng)
        public KhachHangPopupForm()
        {
            InitializeComponent();
            isLoaded = true; // đánh dấu form đã load xong
        }

        // Constructor truyền ID (dùng cho sửa khách hàng)
        public KhachHangPopupForm(int id) : this()
        {
            customerId = id;
            tabKhachHang.SelectedIndex = 1; // chuyển sang tab sửa

            using (var context = new EFDbContext())
            {
                var kh = context.Customers.Find(id);
                if (kh != null)
                {
                    txtTen_Sua.Text = kh.CustomerName;
                    cbGioiTinh_Sua.Text = kh.Gender;
                    txtDiaChi_Sua.Text = kh.Address;
                    txtSDT_Sua.Text = kh.PhoneNumber;
                    txtEmail_Sua.Text = kh.Email;
                }
            }
        }

        // Sự kiện chuyển tab (bật/tắt đúng nút theo tab)
        private void tabKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return; // ngăn chạy khi form chưa khởi tạo xong

            btnThemKH.Enabled = (tabKhachHang.SelectedIndex == 0);
            btnCapNhatKH.Enabled = (tabKhachHang.SelectedIndex == 1);
        }

        // Thêm khách hàng
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            using (var context = new EFDbContext())
            {
                var kh = new Customer
                {
                    CustomerName = txtTen_Them.Text.Trim(),
                    Gender = cbGioiTinh_Them.Text,
                    Address = txtDiaChi_Them.Text.Trim(),
                    PhoneNumber = txtSDT_Them.Text.Trim(),
                    Email = txtEmail_Them.Text.Trim()
                };

                context.Customers.Add(kh);
                context.SaveChanges();
                MessageBox.Show("Đã thêm khách hàng thành công!", "Thông báo");
                this.Close();
            }
        }

        // Cập nhật thông tin khách hàng
        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            if (customerId == null) return;

            using (var context = new EFDbContext())
            {
                var kh = context.Customers.Find(customerId);
                if (kh != null)
                {
                    kh.CustomerName = txtTen_Sua.Text.Trim();
                    kh.Gender = cbGioiTinh_Sua.Text;
                    kh.Address = txtDiaChi_Sua.Text.Trim();
                    kh.PhoneNumber = txtSDT_Sua.Text.Trim();
                    kh.Email = txtEmail_Sua.Text.Trim();

                    context.SaveChanges();
                    MessageBox.Show("Đã cập nhật khách hàng thành công!", "Thông báo");
                    this.Close();
                }
            }
        }

        // Các sự kiện label không cần xử lý
        private void lblGioiTinh_Them_Click(object sender, EventArgs e) { }

        private void lblSDT_Them_Click(object sender, EventArgs e) { }
    }
}
