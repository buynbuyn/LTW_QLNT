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
    }
}
