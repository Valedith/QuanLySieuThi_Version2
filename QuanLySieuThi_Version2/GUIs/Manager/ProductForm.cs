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
        ObservableListSource<ProductType> selectedProductTypes;
        ObservableListSource<Supplier> selectedSuppliers;

        public ProductForm()
        {
            InitializeComponent();
            selectedProductTypes = new ObservableListSource<ProductType>();
            selectedSuppliers = new ObservableListSource<Supplier>();
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
        private void ReloadBindingSources()
        {
            try
            {
                bus.ReloadContext();
                PopulateProductBindingSource(checkBoxShowLocked.Checked);

                productDataGridView.Refresh();
                productTypesDataGridView.Refresh();
                suppliersDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
        }
        #endregion

        #region Events
        private void checkBoxShowLocked_CheckedChanged(object sender, EventArgs e)
        {
            PopulateProductBindingSource(checkBoxShowLocked.Checked);
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new AddProductForm(productTypeBindingSource_All, supplierBindingSource_All, productBrandBindingSource_All).ShowDialog();
            ReloadBindingSources();
        }

        private void productTypesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == productTypesDataGridView.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == productTypesDataGridView.Columns["dataGridViewButtonColumnDeleteSelectedType"].Index)
            {
                productTypesDataGridView.Rows.RemoveAt(e.RowIndex);
                //selectedProductTypes.RemoveAt(e.RowIndex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadBindingSources();
        }



        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            try
            {
                ProductType productType = productTypeBindingSource_All.Current as ProductType;
                if (productType == null) { return; }
                var currentProduct = productBindingSource.Current as Product;
                if (currentProduct == null) { return; }
                foreach (var type in currentProduct.ProductTypes)
                {
                    if (productType.Id == type.Id)
                    {
                        ShowErrorMessagerBox("This Type has already been added");
                        return;
                    }
                }
                currentProduct.ProductTypes.Add(productType);
            }
            catch (Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if(!GetConfirmation("Do you want to edit this product?","Edit Confirm")) { return; }
            try
            {
                Product currentProduct;
                if (productBindingSource.Current as Product != null)
                {
                    currentProduct=productBindingSource.Current as Product;
                }
                else
                {
                    throw new Exception("Couldn't get this Product");
                }
                if (comboBoxProductBrand_Add.SelectedValue != null)
                {
                    currentProduct.Name = txtProductName.Text.Trim();
                    currentProduct.Quantity = (int)numQuantity.Value;
                    currentProduct.Price = numPrice.Value;
                    currentProduct.Detail = txtDetail.Text.Trim();
                    currentProduct.Unit = txtUnit.Text.Trim();
                    currentProduct.IsActive = isActiveCheckBox.Checked;
                    currentProduct.ProductBrandId = (int)comboBoxProductBrand_Add.SelectedValue;
                }
                else
                {
                    throw new Exception("Couldn't get Product Brand");
                }
                
                
                CustomResult cr = bus.EditProducts(currentProduct);
                if (cr.Result == CustomResultType.Succeed)
                {
                    MessageBox.Show("Product edited", "Edit Complete",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productDataGridView.Refresh();
                }
                else if (cr.Result == CustomResultType.InvalidModelState)
                {
                    Validator.ShowErrorMessageBoxes();
                    return;
                }
                else
                {
                    throw new Exception(cr.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
                txtProductName.Focus();
            }
        }
        #endregion

        private void suppliersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == suppliersDataGridView.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == suppliersDataGridView.Columns["dataGridViewButtonColumnDeleteSelectedSupplier"].Index)
            {
                suppliersDataGridView.Rows.RemoveAt(e.RowIndex);
                //selectedProductTypes.RemoveAt(e.RowIndex);
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = supplierBindingSource_All.Current as Supplier;
                if (supplier == null) { return; }
                var currentProduct = productBindingSource.Current as Product;
                if (currentProduct == null) { return; }
                foreach (var item in currentProduct.Suppliers)
                {
                    if (item.Id == supplier.Id)
                    {
                        ShowErrorMessagerBox("This Supplier has already been added");
                        return;
                    }
                }
                currentProduct.Suppliers.Add(supplier);
            }
            catch (Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if(!GetConfirmation("Do you want to delete this product ?", "Delete confirm")) { return; }
            if(MessageBox.Show("ARE YOU SURE TO DELETE THIS PRODUCT, THIS ACTION CAN CAUSE DATA LOSS",
                                       "DELETE CONFIRM",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No){ return; }
            if (MessageBox.Show("THIS FEATURE IS STILL UNDER DEVELOP SO YOU CAN'T GET YOUR DATA BACK, ARE YOU SURE TO PROCEED?",
                                       "DELETE CONFIRM",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No) { return; }
            try
            {
                CustomResult cr = bus.DeleteProduct((productBindingSource.Current as Product).Id);
                if(cr.Result== CustomResultType.Succeed)
                {
                    MessageBox.Show(cr.ErrorMessage);
                }
            }
            catch(Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
        }
    }
}
