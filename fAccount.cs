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
            fAddAccount formAdd_ac = new fAddAccount(this);
            formAdd_ac.TopLevel = false;
            formAdd_ac.FormBorderStyle = FormBorderStyle.None;
            formAdd_ac.Dock = DockStyle.Fill;
            panelAccount.Controls.Add(formAdd_ac);
            panelAccount.Visible = true; // Hiển thị form
            formAdd_ac.Show();

        }
        public void LoadAccountData()
        {
            using (var db = new EFDbContext()) // Kết nối database
            {
                dataGridView1.DataSource = null;

                dataGridView1.AutoGenerateColumns = false;


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
        private void ShowEditAccountForm(int UserID)
        {
            panelAccount.Controls.Clear();
            fEditAccount editAccount = new fEditAccount(UserID, this); // truyền form cha
            editAccount.TopLevel = false;
            editAccount.FormBorderStyle = FormBorderStyle.None;
            editAccount.Dock = DockStyle.Fill;
            panelAccount.Controls.Add(editAccount);
            panelAccount.Visible = true;
            editAccount.FormClosed += (s, e) =>
            {
                panelAccount.Controls.Clear();     // Gỡ form sửa khỏi panel
                LoadAccountData();                 // Cập nhật lại DataGridView
                dataGridView1.Refresh();           // Ép vẽ lại (chắc cú)
            };

            editAccount.Show();

        }
        private void DeleteAccount(int rowIndex)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    var UserIdCell = dataGridView1.Rows[rowIndex].Cells["UserID"].Value;
                    if (UserIdCell != null && int.TryParse(UserIdCell.ToString(), out int UserID))
                    {
                        var UserToDelete = db.Users.Find(UserID);
                        if (UserToDelete != null)
                        {
                            db.Users.Remove(UserToDelete);
                            db.SaveChanges();
                            LoadAccountData(); // Cập nhật danh sách sau khi xóa
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs u)
        {
            if (u.RowIndex >= 0 && u.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[u.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    try
                    {
                        var UserIdCell = dataGridView1.Rows[u.RowIndex].Cells["UserID"].Value;
                        if (UserIdCell != null && int.TryParse(UserIdCell.ToString(), out int UserID))
                        {
                            ShowEditAccountForm(UserID);
                            
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
                        DeleteAccount(u.RowIndex);
                    }
                }
            }
        }
       
    }
}
