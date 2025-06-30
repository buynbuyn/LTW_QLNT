using QLNT.Data;
using QLNT.models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QLNT
{
    public partial class KhoForm : Form
    {
        public KhoForm()
        {
            InitializeComponent();
            this.Load += KhoForm_Load;
            dtgvKho.CellContentClick += DtgvKho_CellContentClick;
            btnthemsp.Click += Btnthemsp_Click;
            btnSearch.Click += BtnSearch_Click;
        }

        private void KhoForm_Load(object sender, EventArgs e)
        {
            LoadKhoData();
        }

        private void LoadKhoData()
        {
            using (var db = new EFDbContext())
            {
                dtgvKho.DataSource = null;
                dtgvKho.Columns.Clear();
                dtgvKho.AutoGenerateColumns = true;

                var list = db.Products
                             .Select(pd => new
                             {
                                 pd.ProductID,
                                 pd.ProductName,
                                 pd.Dosage,
                                 pd.Unit,
                                 pd.Price,
                                 pd.ProductImage // Đường dẫn ảnh
                             })
                             .ToList();

                dtgvKho.DataSource = list;
                AddImageColumn();
                AddActionButtons();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            using (var db = new EFDbContext())
            {
                var list = db.Products
                             .Where(p => p.ProductName.ToLower().Contains(keyword))
                             .Select(p => new
                             {
                                 p.ProductID,
                                 p.ProductName,
                                 p.Dosage,
                                 p.Unit,
                                 p.Price,
                                 p.ProductImage
                             })
                             .ToList();

                dtgvKho.DataSource = null;
                dtgvKho.Columns.Clear();
                dtgvKho.DataSource = list;
                AddImageColumn();
                AddActionButtons();
            }
        }

        private void AddImageColumn()
        {
            if (!dtgvKho.Columns.Contains("ImageColumn"))
            {
                var imgCol = new DataGridViewImageColumn
                {
                    Name = "ImageColumn",
                    HeaderText = "Hình ảnh",
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dtgvKho.Columns.Insert(1, imgCol); // sau cột ProductID
            }

            foreach (DataGridViewRow row in dtgvKho.Rows)
            {
                var data = row.DataBoundItem;
                if (data == null) continue;

                string imagePath = data.GetType().GetProperty("ProductImage")?.GetValue(data) as string;
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    row.Cells["ImageColumn"].Value = Image.FromFile(imagePath);
                }
             
            }
        }

        private void AddActionButtons()
        {
            if (!dtgvKho.Columns.Contains("Edit"))
            {
                var btnEdit = new DataGridViewButtonColumn()
                {
                    Name = "Edit",
                    HeaderText = "Sửa",
                    Text = "Sửa",
                    UseColumnTextForButtonValue = true
                };
                dtgvKho.Columns.Add(btnEdit);
            }

            if (!dtgvKho.Columns.Contains("Delete"))
            {
                var btnDel = new DataGridViewButtonColumn()
                {
                    Name = "Delete",
                    HeaderText = "Xóa",
                    Text = "Xóa",
                    UseColumnTextForButtonValue = true
                };
                dtgvKho.Columns.Add(btnDel);
            }
        }

        private void DtgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var colName = dtgvKho.Columns[e.ColumnIndex].Name;
            var idCell = dtgvKho.Rows[e.RowIndex].Cells["ProductID"].Value;
            if (idCell == null || !int.TryParse(idCell.ToString(), out int ProductID))
            {
                MessageBox.Show("Không thể lấy ID sản phẩm!");
                return;
            }

            if (colName == "Edit")
            {
                ShowEditForm(ProductID);
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa mục này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    DeleteRecord(ProductID);
            }
        }

        private void ShowEditForm(int ProductID)
        {
            panelDetails.Controls.Clear();
            var frm = new fEditProduct(ProductID);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelDetails.Controls.Add(frm);
            panelDetails.Visible = true;
            frm.Show();
            frm.FormClosed += (s, e) => { LoadKhoData(); };
        }

        private void DeleteRecord(int ProductID)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    var pd = db.ProductDetails.Find(ProductID);
                    if (pd != null)
                    {
                        db.ProductDetails.Remove(pd);
                        db.SaveChanges();
                        LoadKhoData();
                    }
                    else MessageBox.Show("Không tìm thấy bản ghi để xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}");
            }
        }

        private void Btnthemsp_Click(object sender, EventArgs e)
        {
            panelDetails.Controls.Clear();
            var frmAdd = new fAddProduct();
            frmAdd.TopLevel = false;
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.Dock = DockStyle.Fill;
            panelDetails.Controls.Add(frmAdd);
            panelDetails.Visible = true;
            frmAdd.Show();
            frmAdd.FormClosed += (s, ev) => { LoadKhoData(); };
        }

        private void panelDetails_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
