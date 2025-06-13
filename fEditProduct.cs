using QLNT.Data;
using QLNT.models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLNT
{
    public partial class fEditProduct : Form
    {
        private readonly int _productId;
        public fEditProduct(int productId)
        {
            InitializeComponent();
            _productId = productId;
        }

        private void fEditProduct_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                cbCategory.DataSource = db.Categories.ToList();
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";

                cbManufacturer.DataSource = db.Manufacturers.ToList();
                cbManufacturer.DisplayMember = "ManufacturerName";
                cbManufacturer.ValueMember = "ManufacturerID";

                var sp = db.Products.Find(_productId);
                if (sp != null)
                {
                    txtName.Text = sp.ProductName;
                    txtDosage.Text = sp.Dosage;
                    txtUnit.Text = sp.Unit;
                    txtPrice.Text = sp.Price.ToString();
                    cbCategory.SelectedValue = sp.CategoryID;
                    cbManufacturer.SelectedValue = sp.ManufactureID;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var sp = db.Products.Find(_productId);
                if (sp != null)
                {
                    sp.ProductName = txtName.Text;
                    sp.Dosage = txtDosage.Text;
                    sp.Unit = txtUnit.Text;
                    sp.Price = decimal.Parse(txtPrice.Text);
                    sp.CategoryID = (int)cbCategory.SelectedValue;
                    sp.ManufactureID = (int)cbManufacturer.SelectedValue;

                    db.SaveChanges();
                    MessageBox.Show("Đã cập nhật sản phẩm.");
                    this.Close();
                }
            }
        }
    }
}
