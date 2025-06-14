
﻿using System.Drawing.Drawing2D;

namespace QLNT

{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();


        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.UserRole == 2) // Chỉ cho phép người có role = 2 mở form
            {
                fEmployee employeeForm = new fEmployee();
                employeeForm.MdiParent = this; // Thiết lập fMain làm form cha
                employeeForm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.UserRole == 2)
            {
                fAccount accountForm = new fAccount();
                accountForm.MdiParent = this; // Thiết lập fMain làm form cha
                accountForm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.IsMdiContainer = true;
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DoanhThuForm();
            form.MdiParent = this;
            form.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new KhachHangForm();
            form.MdiParent = this;
            form.Show();
        }

        private void cửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CuaHangForm();
            form.MdiParent = this;
            form.Show();
        }



        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoadon giohang = new Hoadon();
            giohang.MdiParent = this;
            giohang.Show();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoForm khohang = new KhoForm();
            khohang.MdiParent = this;
            khohang.Show();
        }

        private void lịchSửHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LSHDForm lshd = new LSHDForm();
            lshd.MdiParent = this;
            lshd.Show();
        }
    }
}
