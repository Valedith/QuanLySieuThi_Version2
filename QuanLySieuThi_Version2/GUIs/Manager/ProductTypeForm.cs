using AutoMapper;
using QuanLySieuThi_Version2.BUS;
using QuanLySieuThi_Version2.Infrastructures;
using QuanLySieuThi_Version2.Models;
using QuanLySieuThi_Version2.Models.DTOs;
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
    public partial class ProductTypeForm : Form
    {

        ProductTypeBUS bus = new ProductTypeBUS();
        public ProductTypeForm()
        {
            InitializeComponent();
            CreateSearchProductTypeOptions();
        }

        #region Exe Order
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                productTypeBindingSource.DataSource = bus.GetAllProductTypes();
                productTypeBindingSource_AddProducts.DataSource = bus.GetAllProductTypes();
                productBindingSource_Add.DataSource = bus.GetAllProducts();
            }
            catch(Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            bus.Dispose();
            base.OnClosing(e);
        }
        #endregion

        #region Private methods
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
        private void GetInvalidModelStateErrors()
        {
            foreach (var error in ModelState.ErrorMessages)
                MessageBox.Show(error, "Error"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
        }
        private void CreateSearchProductTypeOptions()
        {
            comboBoxSearchProductTypeOptions.DisplayMember = "Text";
            comboBoxSearchProductTypeOptions.ValueMember = "Value";
            comboBoxSearchProductTypeOptions.Items.Add(new { Text = "ID", Value = "ID" });
            comboBoxSearchProductTypeOptions.Items.Add(new { Text = "Name", Value = "Name" });
            comboBoxSearchProductTypeOptions.SelectedIndex = 0;
        }
        #endregion

        #region Events
        #region ProductType Events
        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GetConfirmation("Are you sure to add this Product Type ?", "Confirm Add"))
                {
                    return;
                }
                CustomResult customResult = bus.AddProductType(new ProductType()
                {
                    Name = txtProductTypeName.Text.Trim(),
                    IsActive = checkBoxIsActive.Checked
                });
                if (customResult.Result == CustomResultType.Succeed)
                {
                    MessageBox.Show("Product Type added!", "Add Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productTypeDataGridView.Refresh();
                }
                else if (customResult.Result == CustomResultType.InvalidModelState)
                {
                    GetInvalidModelStateErrors();
                }
                else
                {
                    throw new Exception(customResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
            txtProductTypeName.Focus();
        }
        private void btnEditProductType_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GetConfirmation("Are you sure to edit this Product Type", "Edit Confirm"))
                {
                    return;
                }
                ProductType productType = productTypeBindingSource.Current as ProductType;
                productType.Name = txtProductTypeName.Text.Trim();
                productType.IsActive = checkBoxIsActive.Checked;
                CustomResult customResult = bus.EditProductType(productType);
                if (customResult.Result == CustomResultType.Succeed)
                {
                    MessageBox.Show("Product Type edited!", "Edit Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productTypeDataGridView.Refresh();
                }
                else if (customResult.Result == CustomResultType.InvalidModelState)
                {
                    GetInvalidModelStateErrors();
                }
                else
                {
                    throw new Exception(customResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
            txtProductTypeName.Focus();
        }
        private void btnLockProductType_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GetConfirmation("Are you sure to Lock/Unlock this Product Type", "Lock/Unlock Confirm"))
                {
                    return;
                }
                ProductType productType = productTypeBindingSource.Current as ProductType;
                productType.IsActive = !productType.IsActive;
                bool currentLockStatus = productType.IsActive;
                CustomResult customResult = bus.EditProductType(productType);
                if (customResult.Result == CustomResultType.Succeed)
                {
                    MessageBox.Show(currentLockStatus ? "Product Type unLocked!" : "Product Type locked!"
                        , "Edit Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productTypeDataGridView.Refresh();
                }
                else if (customResult.Result == CustomResultType.InvalidModelState)
                {
                    GetInvalidModelStateErrors();
                }
                else
                {
                    throw new Exception(customResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
        }
        private void btnRefreshProductTypeGrid_Click(object sender, EventArgs e)
        {
            productTypeBindingSource.DataSource = bus.GetAllProductTypes();
        }
        private void btnSearchProductType_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSearchProductTypeValue.Text.Trim())) { return; }
                if ((comboBoxSearchProductTypeOptions.SelectedItem as dynamic).Value == "ID")
                {
                    int id;
                    if(!Int32.TryParse(txtSearchProductTypeValue.Text, out id))
                    {
                        throw new Exception("Invalid search value");
                    }
                    productTypeBindingSource.DataSource = bus.SearchProductTypeByID(id);
                }
                else
                {
                    productTypeBindingSource.DataSource = bus.SearchProductTypeByName(txtSearchProductTypeValue.Text.Trim());
                }
            }
            catch(Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
            
        }

        #endregion
        #region ProductType-Product Events
        private void btnAddProductTypeProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if(!GetConfirmation("Are you sre to add this record?", "Confirm Add")) { return; }
                int productTypeId, productId;
                if (Int32.TryParse(comboBoxAddProduct.SelectedValue.ToString(), out productId)
                    && Int32.TryParse(comboBoxAddProductType.SelectedValue.ToString(), out productTypeId))
                {
                    CustomResult customResult = bus.AddProductTypeProduct(productTypeId, productId);
                    if(customResult.Result == CustomResultType.Succeed)
                    {
                        MessageBox.Show("Record added", "Add Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception(customResult.ErrorMessage);
                    }
                }
                else
                {
                    throw new Exception("Couldn't get Product or Prouct Type");
                }
            }
            catch(Exception ex)
            {
                ShowErrorMessagerBox(ex.Message);
            }
        }
        #endregion
        #endregion


    }
}
