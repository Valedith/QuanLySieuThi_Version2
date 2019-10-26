using QuanLySieuThi_Version2.BUS;
using QuanLySieuThi_Version2.Infrastructures;
using QuanLySieuThi_Version2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi_Version2.GUIs.Manager
{
    public partial class ProductForm : Form
    {
        ProductBUS bus = new ProductBUS();
        public ProductForm()
        {
            InitializeComponent();
        }
        #region exe orders
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                productBrandBindingSource_All.DataSource = bus.GetProductBrands();
                productTypeBindingSource_All.DataSource = bus.GetProductTypes();
                supplierBindingSource_All.DataSource = bus.GetSuppliers();
            }
            catch (Exception ex)
            {
                ShowErrorMessagerBox("Some unexpected error has occured.\n" + ex.Message);
            }
            PopulateProductBindingSource(false);

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            bus.Dispose();
            base.OnClosing(e);
        }
        #endregion

        #region Private Methods
        private void PopulateProductBindingSource(bool showLocked)
        {
            try
            {
                productBindingSource.DataSource = bus.GetAllProducts(showLocked);
            }
            catch (Exception ex)
            {
                ShowErrorMessagerBox("Some unexpected error has occured.\n" + ex.Message);
            }
        }
        private bool GetConfirmation(string question, string caption)
        {
            var confirmResult = MessageBox.Show(question,
                                       caption,
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.No) { return false; }
            return true;
        }
        private void ShowErrorMessagerBox(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ShowErrorMessagerBox(string errorMessage, string caption)
        {
            MessageBox.Show(errorMessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Events
        private void checkBoxShowLocked_CheckedChanged(object sender, EventArgs e)
        {
            PopulateProductBindingSource(checkBoxShowLocked.Checked);
        }
        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedProductType = productTypeBindingSource_All.Current as ProductType;
                if (selectedProductType == null) { return; }
                foreach (DataGridViewRow row in dataGridViewSelectedTypes.Rows)
                {
                    if (row.Cells[0].Value.ToString() == selectedProductType.Id.ToString())
                    {
                        ShowErrorMessagerBox("Already had this Type");
                        return;
                    }
                }
                var index = dataGridViewSelectedTypes.Rows.Add();
                dataGridViewSelectedTypes.Rows[index].Cells[0].Value = selectedProductType.Id;
                dataGridViewSelectedTypes.Rows[index].Cells[1].Value = selectedProductType.Name;
            }
            catch (Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedSupplier = supplierBindingSource_All.Current as Supplier;
                if (selectedSupplier == null) { return; }
                foreach (DataGridViewRow row in dataGridViewSelectedSuppliers.Rows)
                {
                    if (row.Cells[0].Value.ToString() == selectedSupplier.Id.ToString())
                    {
                        ShowErrorMessagerBox("Already had this Supplier");
                        return;
                    }
                }
                var index = dataGridViewSelectedTypes.Rows.Add();
                dataGridViewSelectedTypes.Rows[index].Cells[0].Value = selectedSupplier.Id;
                dataGridViewSelectedTypes.Rows[index].Cells[1].Value = selectedSupplier.Name;
            }
            catch (Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            GetConfirmation("Do you want to add this Product?", "Confirm add");
            try
            {
                Product product = new Product(txtProductName.Text.Trim(),
                                            (int)numQuantity.Value,
                                            numPrice.Value,
                                            txtDetail.Text.Trim(),
                                            isActiveCheckBox.Checked,
                                            productBrandBindingSource_All.Current as ProductBrand
                                            );
                List<ProductType> selectedProductTypes = new List<ProductType>();
                foreach (DataGridViewRow row in dataGridViewSelectedTypes.Rows)
                {
                    ProductType productType = new ProductType();
                    productType.Id = Int32.Parse(row.Cells[0].Value.ToString());
                    product.ProductTypes = new ObservableListSource<ProductType>();
                    product.ProductTypes.Add(productType);
                }
                CustomResult cr = bus.AddProduct(product);
                if (cr.Result == CustomResultType.Succeed)
                {
                    MessageBox.Show("DONE");
                }
                else
                {
                    throw new Exception(cr.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
        }
        #endregion


    }
}
