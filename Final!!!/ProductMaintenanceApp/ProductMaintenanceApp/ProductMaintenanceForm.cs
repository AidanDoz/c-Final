

using ProductMaintenanceApp.Models;

namespace ProductMaintenanceApp
{
    public partial class ProductMaintenanceForm : Form
    {
        public ProductMaintenanceForm()
        {
            InitializeComponent();
        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ProductMaintenanceForm_Load(object sender, EventArgs e)
        {
            using (var context = new ProductdbMdfContext())
            {
                var products = context.Products.OrderBy(p => p.Name).ToList();
                lstProduct.DataSource = products;
                lstProduct.DisplayMember = "Name";
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addModifyForm = new AddModifyWindowForm { IsModify = false })
            {
                if (addModifyForm.ShowDialog() == DialogResult.OK)
                {
                    using (var context = new ProductdbMdfContext())
                    {
                        context.Products.Add(addModifyForm.Product);
                        context.SaveChanges();
                        //ProductMaintenanceForm_Load();
                    }
                }
            }
        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            var selectedProduct = (Product)lstProduct.SelectedItem;
            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a product to modify.");
                return;
            }

            using (var modifyForm = new AddModifyWindowForm { IsModify = true, Product = selectedProduct })
            {
                if (modifyForm.ShowDialog() == DialogResult.OK)
                {
                    using (var context = new ProductdbMdfContext())
                    {
                        var product = context.Products.Find(selectedProduct.ProductCode);
                        if (product != null)
                        {
                            product.Name = modifyForm.Product.Name;
                            product.Version = modifyForm.Product.Version;
                            product.ReleaseDate = modifyForm.Product.ReleaseDate;
                            context.SaveChanges();
                            //ProductMaintenanceForm_Load();
                        }
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedProduct = (Product)lstProduct.SelectedItem;
            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a product to remove.");
                return;
            }

            if (MessageBox.Show($"Are you sure you want to remove {selectedProduct.Name}?", "Confirm Removal", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var context = new ProductdbMdfContext())
                {
                    var product = context.Products.Find(selectedProduct.ProductCode);
                    if (product != null)
                    {
                        if (context.Incidents.Any(i => i.ProductCode == product.ProductCode) || context.Registrations.Any(r => r.ProductCode == product.ProductCode))
                        {
                            MessageBox.Show("Cannot remove product with related incidents or registrations.");
                            return;
                        }
                        context.Products.Remove(product);
                        context.SaveChanges();
                        ProductMaintenanceForm_Load(sender, e);
                    }
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }


}











