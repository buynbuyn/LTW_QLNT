using QLNT.Data;
using QLNT.models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLNT
{
    public partial class fEditEmployee : Form
    {
        private int EmployeeID; // Lưu EmployeeID để truy xuất dữ liệu

        public fEditEmployee(int EmployeeID)
        {
            InitializeComponent();
            this.EmployeeID = EmployeeID;  // Gán EmployeeID nhận từ form chính
        }

        private void fEditEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            cbEditPosition.Items.Add("Quản lý");
            cbEditPosition.Items.Add("Giám sát ca");
            cbEditPosition.Items.Add("Nhân viên");
            cbEditGender.Items.Add("Nam");
            cbEditGender.Items.Add("Nữ");

            using (var db = new EFDbContext())
            {
                var employee = db.Employees.FirstOrDefault(e => e.EmployeeID == EmployeeID);
                if (employee != null)
                {
                    txtEditEmployeeName.Text = employee.EmployeeName;
                    cbEditGender.SelectedItem = employee.Gender;
                    cbEditPosition.SelectedItem = employee.Position;
                    txtEditSalary.Text = employee.Salary.ToString();
                    txtEditPhone.Text = employee.PhoneNumber;
                    txtEditEmail.Text = employee.EmailEmployee;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên với ID này!");
                }
            }
        }

        private void btnSaveEditEmployee_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var employee = db.Employees.FirstOrDefault(e => e.EmployeeID == EmployeeID);
                if (employee != null)
                {
                    // Cập nhật dữ liệu
                    employee.EmployeeName = txtEditEmployeeName.Text;
                    employee.Gender = cbEditGender.SelectedItem.ToString();
                    employee.Position = cbEditPosition.SelectedItem.ToString();
                    employee.Salary = decimal.Parse(txtEditSalary.Text);
                    employee.PhoneNumber = txtEditPhone.Text;
                    employee.EmailEmployee = txtEditEmail.Text;

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    LoadEmployeeData();
                    this.Close(); // Đóng form sau khi lưu
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để cập nhật!");
                }
            }
        }
    }
}