
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

        private void fMain_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new BorderMenuRenderer();
            labelUserInfo.Text = $"{Utility.FullName}!";
            labelUserInfo.Location = new Point(
            labelUserInfo.Location.X,
            (panelUserInfo.Height - labelUserInfo.Height) / 2
        );
            int verticalPadding = 5;

            // Đặt chiều cao panel đủ để chứa nút + padding trên và dưới
            panelUserInfo.Height = btnLogout.Height + verticalPadding * 2;

            // Đặt vị trí nút
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(
                panelUserInfo.Width - btnLogout.Width - 10, // Cách mép phải 10px
                verticalPadding                            // Cách mép trên 5px
            );

            // Đảm bảo luôn giữ đúng vị trí khi resize form hoặc panel
            panelUserInfo.Resize += (s, e) =>
            {
                btnLogout.Location = new Point(
                    panelUserInfo.Width - btnLogout.Width - 10,
                    verticalPadding
                );
            };
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
        "Bạn có chắc chắn muốn đăng xuất không?",
        "Xác nhận",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (confirm == DialogResult.Yes)
            {
                // 🧹 Xoá toàn bộ thông tin phiên từ Utility
                Utility.UserRole = 0;
                Utility.LoggedInUser = string.Empty;
                Utility.FullName = string.Empty;

                // 📤 Quay lại form đăng nhập

                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
