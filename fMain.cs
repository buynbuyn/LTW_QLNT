namespace QLNT
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
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

        private void cửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CuaHangForm();
            form.ShowDialog();
        }
    }
}
