using DocumentFormat.OpenXml.Spreadsheet;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLNT
{
    public partial class fAddAccount : Form
    {
        private fAccount parentForm;
        public fAddAccount(fAccount parent)
        {
            InitializeComponent();
            parentForm = parent;

            cbRole.Items.Clear();
            cbRole.Items.Add("1"); // Admin
            cbRole.Items.Add("2");
        }

        private void fAddAccount_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSaveAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new EFDbContext()) 
                {
                    // 🔍 Kiểm tra dữ liệu đầu vào
                    if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                        string.IsNullOrWhiteSpace(txtFullName.Text) ||
                        string.IsNullOrWhiteSpace(txtEmail.Text) ||
                        string.IsNullOrWhiteSpace(txtPassword.Text) ||
                        cbRole.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                        return;
                    }

                    // 🔁 Kiểm tra UserName hoặc Email đã tồn tại
                    bool isExist = db.Users.Any(u => u.UserName == txtUserName.Text || u.Email == txtEmail.Text);
                    if (isExist)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!", "Cảnh báo");
                        return;
                    }

                    // 🔧 Lấy vai trò là số (1: Admin, 2: Nhân viên, ...)
                    int roleValue;
                    if (!int.TryParse(cbRole.SelectedItem.ToString(), out roleValue))
                    {
                        MessageBox.Show("Vai trò không hợp lệ!", "Lỗi");
                        return;
                    }

                    // 🆕 Tạo User mới
                    var User = new User()
                    {
                        UserName = txtUserName.Text.Trim(),
                        FullName = txtFullName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Password = txtPassword.Text.Trim(), // có thể hash nếu cần
                        Role = roleValue,
                        Status = ckStatus.Checked
                    };

                    db.Users.Add(User);
                    db.SaveChanges();


                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo");
                    parentForm.LoadAccountData();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm tài khoản: {ex.Message}", "Lỗi");
            }

        }
    }
}
