using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLNT.Data;

namespace QLNT
{
    public partial class DoanhThuForm : Form
    {
        public DoanhThuForm()
        {
            InitializeComponent();
            this.Load += DoanhThuForm_Load;
        }

        private void DoanhThuForm_Load(object sender, EventArgs e)
        {
            cboMonth.Items.Clear();
            cboYear.Items.Clear();

            for (int i = 1; i <= 12; i++)
                cboMonth.Items.Add(i);
            for (int y = 2020; y <= DateTime.Now.Year; y++)
                cboYear.Items.Add(y);

            cboMonth.SelectedIndex = DateTime.Now.Month - 1;
            cboYear.SelectedIndex = cboYear.Items.Count - 1;
        }

        private void btnTheoNgay_Click(object sender, EventArgs e)
        {
            if (cboMonth.SelectedItem == null || cboYear.SelectedItem == null) return;
            int month = Convert.ToInt32(cboMonth.SelectedItem);
            int year = Convert.ToInt32(cboYear.SelectedItem);
            LoadRevenueByDay(month, year);
        }

        private void btnTheoThang_Click(object sender, EventArgs e)
        {
            if (cboYear.SelectedItem == null) return;
            int year = Convert.ToInt32(cboYear.SelectedItem);
            LoadRevenueByMonth(year);
        }

        private void LoadRevenueByDay(int month, int year)
        {
            using (var context = new EFDbContext())
            {
                var result = context.Orders
                    .Where(o => o.OrderDate.Year == year && o.OrderDate.Month == month)
                    .GroupBy(o => o.OrderDate.Day)
                    .Select(g => new
                    {
                        Ngay = g.Key,
                        DoanhThu = g.Sum(x => x.Amount)
                    })
                    .OrderBy(x => x.Ngay)
                    .ToList();

                dgvRevenue.DataSource = result;

                if (dgvRevenue.Columns.Count >= 2)
                {
                    dgvRevenue.Columns[0].HeaderText = "Ngày";
                    dgvRevenue.Columns[1].HeaderText = "Doanh thu (VNĐ)";
                }

                lblTotal.Text = "Tổng doanh thu: " + result.Sum(r => r.DoanhThu).ToString("N0") + " VNĐ";

                if (result.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho tháng/năm đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvRevenue.Refresh();
                lblTotal.Text = "Tổng doanh thu: " + result.Sum(r => r.DoanhThu).ToString("N0") + " VNĐ";
                lblTotalBills.Text = "Tổng số hóa đơn: " + context.Orders
                    .Where(o => o.OrderDate.Year == year && o.OrderDate.Month == month)
                    .Count().ToString() + " hóa đơn";

            }
        }


        private void LoadRevenueByMonth(int year)
        {
            using (var context = new EFDbContext())
            {
                var result = context.Orders
                    .Where(o => o.OrderDate.Year == year)
                    .GroupBy(o => o.OrderDate.Month)
                    .Select(g => new
                    {
                        Thang = g.Key,
                        DoanhThu = g.Sum(x => x.Amount)
                    })
                    .OrderBy(x => x.Thang)
                    .ToList();

                dgvRevenue.DataSource = result;

                if (dgvRevenue.Columns.Count >= 2)
                {
                    dgvRevenue.Columns[0].HeaderText = "Tháng";
                    dgvRevenue.Columns[1].HeaderText = "Doanh thu (VNĐ)";
                }

                lblTotal.Text = "Tổng doanh thu: " + result.Sum(r => r.DoanhThu).ToString("N0") + " VNĐ";

                if (result.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho năm đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvRevenue.Refresh();
                lblTotal.Text = "Tổng doanh thu: " + result.Sum(r => r.DoanhThu).ToString("N0") + " VNĐ";
                lblTotalBills.Text = "Tổng số hóa đơn: " + context.Orders
                    .Where(o => o.OrderDate.Year == year)
                    .Count().ToString() + " hóa đơn";
            }
        }

        private void dgvRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
