﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLNT.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using ClosedXML.Excel;

namespace QLNT
{
    public partial class DoanhThuForm : Form
    {
        private List<ChartDataPoint> currentChartData = new List<ChartDataPoint>();

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

            InitializeChart();
        }

        private void InitializeChart()
        {
            chartRevenue.Series.Clear();
            chartRevenue.Titles.Clear();
            chartRevenue.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainChartArea");
            chartRevenue.ChartAreas.Add(chartArea);

            Series series = new Series("VNĐ")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                XValueType = ChartValueType.Int32,
                IsXValueIndexed = false
            };
            chartRevenue.Series.Add(series);

            chartArea.AxisX.Title = "Thời gian";
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisX.LabelStyle.IsEndLabelVisible = true;
            chartArea.AxisX.IsLabelAutoFit = true;
            chartArea.AxisX.LabelStyle.Angle = 0; // Xoay nhãn về ngang
            chartArea.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 8F);
            chartArea.AxisX.IsMarginVisible = true;

            chartArea.AxisY.Title = "Doanh thu (VNĐ)";
            chartArea.AxisY.LabelStyle.Format = "N0";
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            chartRevenue.SuppressExceptions = true;
        }

        private void UpdateChart(IEnumerable<ChartDataPoint> data, string chartTitle, string axisXTitle)
        {
            currentChartData = data.ToList(); // Lưu dữ liệu cho export
            chartRevenue.Series["VNĐ"].Points.Clear();
            chartRevenue.Titles.Clear();
            chartRevenue.Titles.Add(chartTitle);

            var chartArea = chartRevenue.ChartAreas["MainChartArea"];
            chartArea.AxisX.Title = axisXTitle;
            chartArea.AxisX.CustomLabels.Clear();

            foreach (var item in data)
            {
                if (int.TryParse(item.Label, out int xValue))
                {
                    chartRevenue.Series["VNĐ"].Points.AddXY(xValue, item.Value);

                    CustomLabel label = new CustomLabel
                    {
                        FromPosition = xValue - 0.5,
                        ToPosition = xValue + 0.5,
                        Text = item.Label
                    };
                    chartArea.AxisX.CustomLabels.Add(label);
                }
            }

            chartRevenue.DataBind();
        }

        private void btnTheoNgay_Click(object sender, EventArgs e)
        {
            if (cboMonth.SelectedItem == null || cboYear.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tháng và năm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int month = Convert.ToInt32(cboMonth.SelectedItem);
            int year = Convert.ToInt32(cboYear.SelectedItem);
            LoadRevenueByDay(month, year);
        }

        private void btnTheoThang_Click(object sender, EventArgs e)
        {
            if (cboYear.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn năm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

                UpdateChart(
                    result.Select(r => new ChartDataPoint
                    {
                        Label = r.Ngay.ToString(),
                        Value = (double)r.DoanhThu
                    }),
                    $"Doanh thu theo ngày ({month}/{year})",
                    "Ngày"
                );

                double totalRevenue = (double)result.Sum(r => r.DoanhThu);
                int totalBills = context.Orders
                    .Where(o => o.OrderDate.Year == year && o.OrderDate.Month == month)
                    .Count();

                lblTotal.Text = "Tổng doanh thu: " + totalRevenue.ToString("N0") + " VNĐ";
                lblTotalBills.Text = "Tổng số hóa đơn: " + totalBills.ToString() + " hóa đơn";

                if (result.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho tháng/năm đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

                UpdateChart(
                    result.Select(r => new ChartDataPoint
                    {
                        Label = r.Thang.ToString(),
                        Value = (double)r.DoanhThu
                    }),
                    $"Doanh thu theo tháng (năm {year})",
                    "Tháng"
                );

                double totalRevenue = (double)result.Sum(r => r.DoanhThu);
                int totalBills = context.Orders
                    .Where(o => o.OrderDate.Year == year)
                    .Count();

                lblTotal.Text = "Tổng doanh thu: " + totalRevenue.ToString("N0") + " VNĐ";
                lblTotalBills.Text = "Tổng số hóa đơn: " + totalBills.ToString() + " hóa đơn";

                if (result.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho năm đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (currentChartData == null || currentChartData.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExportToExcel(currentChartData, chartRevenue.Titles.Count > 0 ? chartRevenue.Titles[0].Text : "Doanh thu");
        }

        private void ExportToExcel(List<ChartDataPoint> data, string title)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Doanh thu");

                worksheet.Cell(1, 1).Value = title;
                worksheet.Cell(1, 1).Style.Font.Bold = true;
                worksheet.Cell(1, 1).Style.Font.FontSize = 14;
                worksheet.Range(1, 1, 1, 2).Merge();

                worksheet.Cell(3, 1).Value = "Thời gian";
                worksheet.Cell(3, 2).Value = "Doanh thu (VNĐ)";
                worksheet.Range(3, 1, 3, 2).Style.Font.Bold = true;

                int row = 4;
                foreach (var item in data)
                {
                    worksheet.Cell(row, 1).Value = item.Label;
                    worksheet.Cell(row, 2).Value = item.Value;
                    worksheet.Cell(row, 2).Style.NumberFormat.Format = "#,##0";
                    row++;
                }

                worksheet.Columns().AdjustToContents();

                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Excel Workbook|*.xlsx",
                    Title = "Lưu báo cáo doanh thu",
                    FileName = "DoanhThu.xlsx"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            // Có thể để trống
        }
    }

    public class ChartDataPoint
    {
        public string Label { get; set; }
        public double Value { get; set; }
    }
}
