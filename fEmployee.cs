    using QLNT.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLNT
{
    public partial class fEmployee : Form
    {
        public fEmployee()
        {
            InitializeComponent();
        }

        private void fEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            AddActionButtons();
        }

        private void LoadEmployeeData()
        {
            using (var db = new EFDbContext()) // Kết nối database
            {
                dtgvEmployee.DataSource = null;
              
                dtgvEmployee.AutoGenerateColumns = true;

                dtgvEmployee.DataSource = db.Employees.Select(e => new
                {
                    e.EmployeeID,
                    e.EmployeeName,
                    e.Gender,
                    e.Position,
                    e.Salary,
                    e.HireDate,
                    e.PhoneNumber,
                    e.EmailEmployee
                }).OrderBy(e => e.EmployeeID).ToList();
            }
        }
        public void LoadEmployeeData(string keyword)
        {
            using (var db = new EFDbContext())
            {
                var filtered = db.Employees
                    .Where(e => e.EmployeeName.ToLower().Contains(keyword.ToLower()))
                    .Select(e => new
                    {
                        e.EmployeeID,
                        e.EmployeeName,
                        e.Gender,
                        e.Position,
                        e.Salary,
                        e.HireDate,
                        e.PhoneNumber,
                        e.EmailEmployee
                    })
                    .OrderBy(e => e.EmployeeID)
                    .ToList();

                dtgvEmployee.AutoGenerateColumns = true;
                dtgvEmployee.DataSource = filtered;
            }
        }

        private void AddActionButtons()
        {
            if (!dtgvEmployee.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "Edit";
                btnEdit.HeaderText = "Sửa";
                btnEdit.Text = "Sửa";
                btnEdit.UseColumnTextForButtonValue = true;
                dtgvEmployee.Columns.Add(btnEdit);
            }

            if (!dtgvEmployee.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Delete";
                btnDelete.HeaderText = "Xóa";
                btnDelete.Text = "Xóa";
                btnDelete.UseColumnTextForButtonValue = true;
                dtgvEmployee.Columns.Add(btnDelete);
            }
        }

        private void ShowEditEmployeeForm(int EmployeeID)
        {
            panelEmployee.Controls.Clear();
            fEditEmployee editEmployee = new fEditEmployee(EmployeeID); // Đúng
            editEmployee.TopLevel = false;
            editEmployee.FormBorderStyle = FormBorderStyle.None;
            editEmployee.Dock = DockStyle.Fill;
            panelEmployee.Controls.Add(editEmployee);
            panelEmployee.Visible = true;
            editEmployee.Show();
        }

        private void DeleteEmployee(int rowIndex)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    var EmployeeIdCell = dtgvEmployee.Rows[rowIndex].Cells["EmployeeID"].Value;
                    if (EmployeeIdCell != null && int.TryParse(EmployeeIdCell.ToString(), out int EmployeeID))
                    {
                        var EmployeeToDelete = db.Employees.Find(EmployeeID);
                        if (EmployeeToDelete != null)
                        {
                            db.Employees.Remove(EmployeeToDelete);
                            db.SaveChanges();
                            LoadEmployeeData(); // Cập nhật danh sách sau khi xóa
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên để xóa!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy ID nhân viên!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}");
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            panelEmployee.Controls.Clear();
            fAddEmployee formAdd = new fAddEmployee();
            formAdd.TopLevel = false;
            formAdd.FormBorderStyle = FormBorderStyle.None;
            formAdd.Dock = DockStyle.Fill;
            panelEmployee.Controls.Add(formAdd);
            panelEmployee.Visible = true;
            formAdd.Show();
        }

        private void btnFindEmployee_Click(object sender, EventArgs e)
        {
            panelEmployee.Controls.Clear();
            fFindEmployee formFind = new fFindEmployee(this);
            formFind.TopLevel = false;
            formFind.FormBorderStyle = FormBorderStyle.None;
            formFind.Dock = DockStyle.Fill;
            panelEmployee.Controls.Add(formFind);
            panelEmployee.Visible = true;
            formFind.Show();
        }

        private void dtgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dtgvEmployee.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    try
                    {
                        var EmployeeIdCell = dtgvEmployee.Rows[e.RowIndex].Cells["EmployeeID"].Value;
                        if (EmployeeIdCell != null && int.TryParse(EmployeeIdCell.ToString(), out int EmployeeID))
                        {
                            ShowEditEmployeeForm(EmployeeID);
                            LoadEmployeeData(); // Cập nhật danh sách sau khi mở form sửa   
                        }
                        else
                        {
                            MessageBox.Show("Không thể lấy ID nhân viên!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi mở form sửa nhân viên: {ex.Message}");
                    }
                }
                else if (columnName == "Delete")
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DeleteEmployee(e.RowIndex);
                    }
                }
            }
        }
    }
}