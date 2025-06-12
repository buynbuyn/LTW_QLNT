using QLNT.Data;
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
    public partial class fAccount : Form
    {
        public fAccount()
        {
            InitializeComponent();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            panelAccount.Controls.Clear(); // Xóa nội dung cũ
            fAddAccount formAdd_ac = new fAddAccount();
            formAdd_ac.TopLevel = false;
            formAdd_ac.FormBorderStyle = FormBorderStyle.None;
            formAdd_ac.Dock = DockStyle.Fill;
            panelAccount.Controls.Add(formAdd_ac);
            panelAccount.Visible = true; // Hiển thị form
            formAdd_ac.Show();

        }
        private void LoadAccountData()
        {
            using (var db = new EFDbContext()) // Kết nối database
            {
                dataGridView1.DataSource = null;

                dataGridView1.AutoGenerateColumns = true;

                dataGridView1.DataSource = db.Users.Select(u => new
                {
                    u.UserID,
                    u.UserName,
                    u.FullName,
                    u.Email,
                    u.Role,
                    u.Status
                }).OrderBy(u => u.UserID).ToList();

            }
        }
        private void AddActionButtons()
        {
            if (!dataGridView1.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "Edit";
                btnEdit.HeaderText = "Sửa";
                btnEdit.Text = "Sửa";
                btnEdit.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnEdit);
            }

            if (!dataGridView1.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Delete";
                btnDelete.HeaderText = "Xóa";
                btnDelete.Text = "Xóa";
                btnDelete.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnDelete);
            }
        }

        private void fAccount_Load_1(object sender, EventArgs e)
        {
            LoadAccountData();
            AddActionButtons();
        }
    }
}
