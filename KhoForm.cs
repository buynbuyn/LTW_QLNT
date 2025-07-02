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
            dtgvKho.CellClick += DtgvKho_CellClick; // Add CellClick event for image display
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
                                   pd.ProductImage // Lưu tên file ảnh, ví dụ: "amoxicillin.jpg"
                               })
                               .ToList();

                dtgvKho.DataSource = list;
                AddActionButtons();
                // No longer need AddViewImageButton as image is shown on row click
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
                AddActionButtons();
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
                    UseColumnTextForButtonValue = true,
                    Width = 70 // Adjust width
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
                    UseColumnTextForButtonValue = true,
                    Width = 70 // Adjust width
                };
                dtgvKho.Columns.Add(btnDel);
            }
        }

        // Changed from CellContentClick to CellClick for general row selection
        private void DtgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dtgvKho.Rows.Count) return;

            // Display image when a row is clicked
            string fileName = dtgvKho.Rows[e.RowIndex].Cells["ProductImage"].Value?.ToString();
            DisplayProductImage(fileName);
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

        private void DisplayProductImage(string fileName)
        {
            pbProductImage.Image = null; // Clear previous image
            pbProductImage.Visible = false; // Hide by default

            if (!string.IsNullOrWhiteSpace(fileName))
            {
                string imageDirectory = Path.Combine(Application.StartupPath, "images"); // Consider 'images' folder
                if (!Directory.Exists(imageDirectory))
                {
                    Directory.CreateDirectory(imageDirectory);
                }

                string fullPath = Path.Combine(imageDirectory, fileName);

                if (File.Exists(fullPath))
                {
                    try
                    {
                        // Use Image.FromFile for loading. Use a new Bitmap to avoid locking the file.
                        pbProductImage.Image = Image.FromFile(fullPath);
                        pbProductImage.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi tải ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pbProductImage.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy ảnh '{fileName}' trong thư mục '{imageDirectory}'.", "Ảnh không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pbProductImage.Visible = false;
                }
            }
            else
            {
                //MessageBox.Show("Tên file ảnh rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pbProductImage.Visible = false;
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
            frm.FormClosed += (s, e) => {
                LoadKhoData();
                panelDetails.Visible = false; // Hide panel after form is closed
                DisplayProductImage(null); // Clear image
            };
        }

        private void DeleteRecord(int ProductID)
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    // Corrected: Use db.Products instead of db.ProductDetails
                    var pd = db.Products.Find(ProductID);
                    if (pd != null)
                    {
                        // Delete associated image file if it exists
                        if (!string.IsNullOrWhiteSpace(pd.ProductImage))
                        {
                            string imagePath = Path.Combine(Application.StartupPath, "images", pd.ProductImage);
                            if (File.Exists(imagePath))
                            {
                                try
                                {
                                    File.Delete(imagePath);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Không thể xóa file ảnh: {ex.Message}", "Lỗi xóa ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }

                        db.Products.Remove(pd);
                        db.SaveChanges();
                        MessageBox.Show("Xóa sản phẩm thành công!");
                        LoadKhoData();
                        DisplayProductImage(null); // Clear image after deletion
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bản ghi để xóa!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            frmAdd.FormClosed += (s, ev) => {
                LoadKhoData();
                panelDetails.Visible = false; // Hide panel after form is closed
                DisplayProductImage(null); // Clear image
            };
        }

        private void panelDetails_Paint(object sender, PaintEventArgs e)
        {
            // You can add custom painting here if needed for panelDetails
        }
    }
}