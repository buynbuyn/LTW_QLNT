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
    public partial class fEmployee : Form
    {
        public fEmployee()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            panelEmployee.Controls.Clear(); // Xóa nội dung cũ
            fAddEmployee formAdd = new fAddEmployee();
            formAdd.TopLevel = false; // Để nhúng vào Panel
            formAdd.FormBorderStyle = FormBorderStyle.None; // Xóa viền cửa sổ
            formAdd.Dock = DockStyle.Fill; // Căn chỉnh vừa với Panel
            panelEmployee.Controls.Add(formAdd);
            panelEmployee.Visible = true; // Hiển thị form
            formAdd.Show();

        }

        private void btnFindEmployee_Click(object sender, EventArgs e)
        {
            panelEmployee.Controls.Clear(); // Xóa nội dung cũ
            fFindEmployee formFind = new fFindEmployee();
            formFind.TopLevel = false;
            formFind.FormBorderStyle = FormBorderStyle.None;
            formFind.Dock = DockStyle.Fill;
            panelEmployee.Controls.Add(formFind);
            panelEmployee.Visible = true; // Hiển thị form
            formFind.Show();

        }
    }
}
