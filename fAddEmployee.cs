using QLNT.Data;
using QLNT.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    public partial class fAddEmployee : Form
    {
        public fAddEmployee()
        {
            InitializeComponent();
        }

        private void btnSaveAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    // Kiểm tra dữ liệu đầu vào
                    if (string.IsNullOrWhiteSpace(txtEmployeeName.Text) ||
                        cbGender.SelectedItem == null ||
                        cbPosition.SelectedItem == null ||
                        cbAddStatus.Checked == null ||
                        string.IsNullOrWhiteSpace(txtSalary.Text) ||
                        string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                        string.IsNullOrWhiteSpace(txtEmailEmployee.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                        return;
                    }

                    // Chuyển đổi lương (`decimal.TryParse`)
                    if (!decimal.TryParse(txtSalary.Text, out decimal salary))
                    {
                        MessageBox.Show("Lương phải là số!", "Lỗi");
                        return;
                    }

                    // Tạo nhân viên mới
                    Employee newEmployee = new Employee()
                    {
                        EmployeeName = txtEmployeeName.Text,
                        Gender = cbGender.SelectedItem.ToString(),
                        Position = cbPosition.SelectedItem.ToString(),
                        Salary = salary,
                        PhoneNumber = txtPhoneNumber.Text,
                        EmailEmployee = txtEmailEmployee.Text,
                        HireDate = dateTimePicker1.Value // Ngày vào làm việc do người dùng chọn
                    };

                    // Thêm vào database
                    db.Employees.Add(newEmployee);
                    db.SaveChanges();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");

                    // Cập nhật danh sách nhân viên trong `fEmployee`


                    this.Close(); // Đóng form sau khi lưu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi");
            }

        }

        private void fAddEmployee_Load(object sender, EventArgs e)
        {
            cbPosition.Items.Clear();
            cbPosition.Items.Add("Quản lý");
            cbPosition.Items.Add("Giám sát ca");
            cbPosition.Items.Add("Nhân viên");

            cbGender.Items.Clear();
            cbGender.Items.Add("Nam");
            cbGender.Items.Add("Nữ");
        }
    }
}
