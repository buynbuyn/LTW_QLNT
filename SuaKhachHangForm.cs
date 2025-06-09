using QLNT.Data;
using QLNT.models;
using System;
using System.Windows.Forms;

namespace QLNT
{
    public partial class SuaKhachHangForm : Form
    {
        private int customerId;

        public SuaKhachHangForm(int id)
        {
            InitializeComponent();
            customerId = id;
            LoadThongTinKhachHang();
        }

        private void LoadThongTinKhachHang()
        {
            using (var context = new EFDbContext())
            {
                var kh = context.Customers.Find(customerId);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Đã cập nhật khách hàng!");
                    this.Close();
                }
            }
        }
    }
}
