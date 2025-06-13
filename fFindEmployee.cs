using QLNT.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLNT
{
    public partial class fFindEmployee : Form
    {
        private fEmployee _mainForm;

        // Constructor có tham số
        public fFindEmployee(fEmployee mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtEmployeeName.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                _mainForm.LoadEmployeeData(keyword);
                this.Close(); // Đóng form tìm nếu muốn
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}