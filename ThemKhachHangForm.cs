using QLNT.Data;
using QLNT.models;
using System;
using System.Windows.Forms;

namespace QLNT
{
    public partial class ThemKhachHangForm : Form
    {
        public ThemKhachHangForm()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
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
                MessageBox.Show("Đã thêm khách hàng thành công!");
                this.Close();
            }
        }

        private void txtTen_Them_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
