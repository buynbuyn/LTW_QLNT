using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class fEditAccount : Form
    {
        private fAccount parentForm; // Tham chiếu đến form cha
        private int UserID;
        public fEditAccount(int UserID, fAccount parent)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.parentForm = parent;

        }

        private void fEditAccount_Load(object sender, EventArgs e)
        {
        }

        private void btnSaveEditAccount_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserID == UserID);
                if (user != null)
                {
                    // Cập nhật dữ liệu
                    user.FullName = txtEditFullName.Text;
                    user.UserName = txtEditUserName.Text; // Nếu có ô nhập Username
                    user.Email = txtEditEmail.Text;
                    user.Role = Convert.ToInt32(cbEditRole.SelectedItem);  // Nếu dùng ComboBox cho quyền
                    user.Status = ckEditStatus.Checked; // Nếu dùng CheckBox cho trạng thái

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    parentForm.LoadAccountData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để cập nhật!");
                }
            }
        }
    }
}
