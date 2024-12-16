using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ProductMaintenanceApp.Models;

namespace ProductMaintenanceApp
{
    public partial class AddModifyWindowForm : Form
    {
        public Product Product { get; set; }
        public bool IsModify { get; set; }

        public AddModifyWindowForm()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbVersion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbReleaseDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (IsModify)
                {
                    UpdateProduct();
                }
                else
                {
                    AddProduct();
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateFields()
        {
            // Validate input fields and show error messages if necessary
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Please enter the product name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbVersion.Text))
            {
                MessageBox.Show("Please enter the product version.");
                return false;
            }

            if (!DateTime.TryParse(tbReleaseDate.Text, out var releaseDate) ||
                releaseDate < new DateTime(1753, 1, 1) || releaseDate > new DateTime(9999, 12, 31))
            {
                MessageBox.Show("Please enter a valid release date (yyyy-mm-dd).");
                return false;
            }

            return true;
        }

        private void lbProductCode_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct()
        {
            Product = new Product
            {
                ProductCode = tbProductCode.Text,
                Name = tbName.Text,
                Version = decimal.Parse(tbVersion.Text),
                ReleaseDate = DateTime.Parse(tbReleaseDate.Text)
            };
        }

        private void UpdateProduct()
        {
            Product.Name = tbName.Text;
            Product.Version = decimal.Parse(tbVersion.Text);
            Product.ReleaseDate = DateTime.Parse(tbReleaseDate.Text);
        }

        private void AddModifyFormLoad(object sender, EventArgs e)
        {
            if (IsModify && Product != null)
            {
                tbProductCode.Text = Product.ProductCode;
                tbName.Text = Product.Name;
                tbVersion.Text = Product.Version.ToString();
                tbReleaseDate.Text = Product.ReleaseDate.ToString("MM/dd/yyyy");
                tbProductCode.Enabled = false;
            }
        }
    }
}


