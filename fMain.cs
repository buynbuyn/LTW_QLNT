namespace QLNT
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
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
