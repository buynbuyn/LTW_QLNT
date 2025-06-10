using System.Drawing.Drawing2D;

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
            fEmployee employeeForm = new fEmployee();
            employeeForm.MdiParent = this; // Thiết lập fMain làm form cha
            employeeForm.Show();

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount accountForm = new fAccount();
            accountForm.MdiParent = this; // Thiết lập fMain làm form cha
            accountForm.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DoanhThuForm();
            form.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new KhachHangForm();
            form.ShowDialog();
        }
    }
}
