

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
                        ProductMaintenanceFormLoad(sender, e);
                    }
                }
            }
        }


       
        private void btnModify_Click(object sender, EventArgs e)
        {
            var selectedString = lstProduct.SelectedItem as string;
            if (string.IsNullOrEmpty(selectedString))
            {
                MessageBox.Show("Please select a product to modify.");
                return;
            }

            // Extract the ProductCode from the selected string by splitting at the first tab character
            var parts = selectedString.Split('\t');
            var productCode = parts[0].Trim();

            using (var context = new ProductdbMdfContext())
            {
                var selectedProduct = context.Products.FirstOrDefault(p => p.ProductCode == productCode);
                if (selectedProduct == null)
                {
                    MessageBox.Show($"Product {productCode} not found in the database.");
                    return;
                }

                using (var modifyForm = new AddModifyWindowForm { IsModify = true, Product = selectedProduct })
                {
                    if (modifyForm.ShowDialog() == DialogResult.OK)
                    {
                        var product = context.Products.Find(selectedProduct.ProductCode);
                        if (product != null)
                        {
                            product.Name = modifyForm.Product.Name;
                            product.Version = modifyForm.Product.Version;
                            product.ReleaseDate = modifyForm.Product.ReleaseDate;
                            context.SaveChanges();
                            ProductMaintenanceFormLoad(sender, e);
                        }
                    }
                }
            }
        }


        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedString = lstProduct.SelectedItem as string;
            if (string.IsNullOrEmpty(selectedString))
            {
                MessageBox.Show("Please select a product to remove.");
                return;
            }

            // Extract the ProductCode from the selected string by splitting at the first tab character
            var parts = selectedString.Split('\t');
            var productCode = parts[0].Trim(); // Assuming ProductCode is before the first tab character

            using (var context = new ProductdbMdfContext())
            {
                var selectedProduct = context.Products.FirstOrDefault(p => p.ProductCode == productCode);
                if (selectedProduct == null)
                {
                    MessageBox.Show($"Product {productCode} not found in the database.");
                    return;
                }

                if (context.Incidents.Any(i => i.ProductCode == selectedProduct.ProductCode) ||
                    context.Registrations.Any(r => r.ProductCode == selectedProduct.ProductCode))
                {
                    MessageBox.Show("Cannot remove product with related incidents or registrations.");
                    return;
                }

                if (MessageBox.Show($"Are you sure you want to remove {selectedProduct.Name}?", "Confirm Removal", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.Products.Remove(selectedProduct);
                    context.SaveChanges();
                    ProductMaintenanceFormLoad(sender, e); // Refresh the product list
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductMaintenanceFormLoad(object sender, EventArgs e)
        {
            using (var context = new ProductdbMdfContext())
            {
                var products = context.Products
                                      .OrderBy(p => p.Name)
                                      .Select(p => new
                                      {
                                          p.ProductCode,
                                          p.Name,
                                          p.Version,
                                          p.ReleaseDate
                                      })
                                      .ToList();

                lstProduct.Items.Clear();

                // Define the maximum lengths for padding
                int codePad = 15;
                int namePad = 40;
                int versionPad = 10;

                foreach (var product in products)
                {
                    string productDisplay = $"{product.ProductCode.PadRight(codePad)}\t" +
                                            $"{product.Name.PadRight(namePad)}\t" +
                                            $"{product.Version.ToString().PadRight(versionPad)}\t" +
                                            $"{product.ReleaseDate.ToShortDateString()}";
                    lstProduct.Items.Add(productDisplay);
                }
            }

        }
    }


}












