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
    public partial class SupplierForm : Form
    {
        #region Private variables
        SupplierBUS bus = new SupplierBUS();
        Validator validator = new Validator();
        #endregion
        #region Constructors
        public SupplierForm()
        {
            InitializeComponent();
            CreateControlDictionary();
            CreateSearchOptionsComboBox();
            CreateSupplierProductSearchOptionsComboBox();


        }
        #endregion
        #region Execution Orders
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                ReloadSupplierBindingSource();
                ReloadSuppliersProductsBindingSource_Grid();
                checkBoxIsActive.Checked = true;
                ActiveControl = txtSearchValue;

                //Generate datas for 2 Combo boxes of add supplier - product
                ReloadAddSupplierProductBindingSource_Supplier();
                ReloadAddSupplierProductBindingSource_Product();

                ReloadRemoveSupplierProductBindingSource_Supplier();
                ReloadRemoveSupplierProductBindingSource_Product();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            bus.Dispose();
            base.OnClosing(e);
        }
        #endregion

        #region Private functions
        private bool GetConfirmation(string question, string caption)
        {
            var confirmResult = MessageBox.Show(question,
                                       caption,
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.No) { return false; }
            return true;
        }
        private void CreateControlDictionary()
        {
            string supplierString = typeof(Supplier).Name;
            validator.AddControlDictionary(supplierString, "Name", txtSupplierName);
            validator.AddControlDictionary(supplierString, "Address", txtSupplierAddress);
            validator.AddControlDictionary(supplierString, "PhoneNumber", txtSupplierPhoneNumber);
        }
        void ClearSupplierTextBoxes()
        {
            txtSupplierAddress.Clear();
            txtSupplierName.Clear();
            txtSupplierPhoneNumber.Clear();
            checkBoxIsActive.Checked = true;
        }
        private void ReloadSupplierBindingSource()
        {
            supplierBindingSource.DataSource = bus.GetAllSuppliersBindingList();
        }
        private void CreateSearchOptionsComboBox()
        {
            comboBoxSearchOptions.DisplayMember = "Text";
            comboBoxSearchOptions.ValueMember = "Value";
            comboBoxSearchOptions.Items.Add(new { Text = "ID", Value = "ID" });
            comboBoxSearchOptions.Items.Add(new { Text = "Name", Value = "Name" });
            comboBoxSearchOptions.SelectedIndex = 0;
        }
        private void CreateSupplierProductSearchOptionsComboBox()
        {
            comboBoxSupplierProductSearchOptions.DisplayMember = "Text";
            comboBoxSupplierProductSearchOptions.ValueMember = "Value";
            comboBoxSupplierProductSearchOptions.Items.Add(new { Text = "Supplier ID", Value = "SupplierId" });
            comboBoxSupplierProductSearchOptions.Items.Add(new { Text = "Supplier Name", Value = "SupplierName" });
            comboBoxSupplierProductSearchOptions.Items.Add(new { Text = "Product ID", Value = "ProductId" });
            comboBoxSupplierProductSearchOptions.Items.Add(new { Text = "Product Name", Value = "ProductName" });
            comboBoxSupplierProductSearchOptions.SelectedIndex = 0;
        }

        private void ReloadSuppliersProductsBindingSource_Grid()
        {
            supplierProductDTOBindingSource.DataSource = bus.GetAllSupplierProductDTOBindingList();
        }
        private void ReloadAddSupplierProductBindingSource_Supplier()
        {
            addSupplierProductBindingSource_Supplier.DataSource = bus.GetAllSuppliersWithNamePlusId();
        }
        private void ReloadAddSupplierProductBindingSource_Product()
        {
            addSupplierProductBindingSource_Product.DataSource = bus.GetAllProductsWithNamePlusId();
        }
        private void ReloadRemoveSupplierProductBindingSource_Supplier()
        {
            removeSupplierProductBindingSource_Supplier.DataSource = bus.GetAllSupplierProductDTOWithNamePlusId();
        }
        private void ReloadRemoveSupplierProductBindingSource_Product()
        {
            try
            {
                removeSupplierProductsBindingSource_Product.DataSource = bus.GetProductsBySupplierWithNamePlusId((int)comboBoxEditSuppliersProducts_Suppliers.SelectedValue);
            }
            catch
            {
                removeSupplierProductsBindingSource_Product.DataSource = null;
            }
        }
        #endregion

        #region Events
        #region Supplier Events
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GetConfirmation("Are you sure to add this Supplier?", "Confirm Add!!"))
                {
                    return;
                }

                Supplier supplier = new Supplier(txtSupplierName.Text.Trim(),
                                            txtSupplierAddress.Text.Trim(),
                                            txtSupplierPhoneNumber.Text.Trim(),
                                            checkBoxIsActive.Checked);
                CustomResult customResult = bus.AddSupplier(supplier);
                if (customResult.Result == CustomResultType.Succeed)
                {
                    supplierDataGridView.Refresh();
                    MessageBox.Show("Supplier Added",
                                "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearSupplierTextBoxes();
                    ReloadAddSupplierProductBindingSource_Supplier();
                    txtSupplierName.Focus();
                }
                else if (customResult.Result == CustomResultType.InvalidModelState)
                {
                    validator.DisplayModelValidationErrorsAndFocus(supplier.GetType());
                }
                else if (customResult.Result == CustomResultType.InvalidInput)
                {
                    MessageBox.Show(customResult.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSupplierPhoneNumber.Focus();
                }
                else
                {
                    throw new Exception(customResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierName.Focus();
            }
        }
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GetConfirmation("Are you sure to edit this Supplier?", "Confirm Edit!!"))
                {
                    return;
                }

                Supplier supplier = new Supplier(txtSupplierName.Text.Trim(),
                                            txtSupplierAddress.Text.Trim(),
                                            txtSupplierPhoneNumber.Text.Trim(),
                                            checkBoxIsActive.Checked);
                if ((supplierBindingSource.Current as Supplier) == null)
                {
                    throw new Exception("Couldn't get this Supplier to Edit");
                }
                supplier.Id = (supplierBindingSource.Current as Supplier).Id;
                CustomResult customResult = bus.EditSupplier(supplier);
                if (customResult.Result == CustomResultType.Succeed)
                {
                    supplierDataGridView.Refresh();
                    MessageBox.Show("Supplier Edited",
                                "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearSupplierTextBoxes();
                    ReloadSuppliersProductsBindingSource_Grid();
                    ReloadAddSupplierProductBindingSource_Supplier();
                    ReloadRemoveSupplierProductBindingSource_Supplier();
                    ReloadRemoveSupplierProductBindingSource_Product();
                    txtSupplierName.Focus();
                }
                else if (customResult.Result == CustomResultType.InvalidModelState)
                {
                    validator.DisplayModelValidationErrorsAndFocus(supplier.GetType());
                }
                else if (customResult.Result == CustomResultType.InvalidInput)
                {
                    MessageBox.Show(customResult.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSupplierPhoneNumber.Focus();
                }
                else
                {
                    throw new Exception(customResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierName.Focus();
            }
        }
        private void btnLockSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GetConfirmation("Are you sure to edit this Supplier?", "Confirm Edit!!"))
                {
                    return;
                }
                if ((supplierBindingSource.Current as Supplier) == null)
                {
                    throw new Exception("Couldn't get this Supplier to Lock/Unlock");
                }
                int id = (supplierBindingSource.Current as Supplier).Id;
                CustomResult customResult = bus.ChangeLockSupplier(id);
                if (customResult.Result == CustomResultType.Succeed)
                {
                    supplierDataGridView.Refresh();
                    ReloadSuppliersProductsBindingSource_Grid();
                    ReloadAddSupplierProductBindingSource_Supplier();
                    ReloadRemoveSupplierProductBindingSource_Supplier();
                    ReloadRemoveSupplierProductBindingSource_Product();
                }
                else if (customResult.Result == CustomResultType.InvalidModelState)
                {
                    validator.DisplayModelValidationErrorsAndFocus(typeof(Supplier));
                }
                else
                {
                    throw new Exception(customResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefreshSupplier_Click(object sender, EventArgs e)
        {
            ReloadSupplierBindingSource();
            supplierDataGridView.Refresh();
        }
        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtSearchValue.Text.Trim())) { return; }
            try
            {
                if ((comboBoxSearchOptions.SelectedItem as dynamic).Value == "ID")
                {
                    int id;
                    if (Int32.TryParse(txtSearchValue.Text, out id))
                    {
                        supplierBindingSource.DataSource = bus.SearchSupplierByID(id);
                    }
                    else
                    {
                        MessageBox.Show("Invalid search value", "Error"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if ((comboBoxSearchOptions.SelectedItem as dynamic).Value == "Name")
                {
                    supplierBindingSource.DataSource = bus.SearchSupplierByName(txtSearchValue.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void supplierDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Supplier supplier = supplierBindingSource.Current as Supplier;
                txtSupplierName.Text = supplier.Name;
                txtSupplierAddress.Text = supplier.Address;
                txtSupplierPhoneNumber.Text = supplier.PhoneNumber;
                checkBoxIsActive.Checked = supplier.IsActive;
            }
            catch
            {
                return;
            }
        }

        private void txtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchSupplier_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        #endregion

        #region Supplier-Product Events
        private void btnAddSuppliersProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GetConfirmation("Are you sure to add this Supplier?", "Confirm Add!!"))
                {
                    return;
                }


                CustomResult customResult = bus.AddSupplierProduct(Int32.Parse(comboBoxAddSuppliersProducts_Supplier.SelectedValue.ToString()),
                                                                Int32.Parse(comboBoxAddSuppliersProducts_Products.SelectedValue.ToString()));
                if (customResult.Result == CustomResultType.Succeed)
                {
                    suppliersProductsDataGridView.Refresh();
                    MessageBox.Show("Supplier-Product Added",
                                "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadSuppliersProductsBindingSource_Grid();
                    ReloadRemoveSupplierProductBindingSource_Supplier();
                }
                else
                {
                    throw new Exception(customResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnStopSupplying_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GetConfirmation("Are you sure to Stop/Unstop this entry?", "Confirm Stop/Unstop!!"))
                {
                    return;
                }

                SupplierProductDTO dto = (removeSupplierProductsBindingSource_Product.Current as SupplierProductDTO);
                CustomResult customResult = bus.ChangeSupplyingStatusSupplierProduct(dto.SupplierId, dto.ProductId);
                if (customResult.Result == CustomResultType.Succeed)
                {
                    MessageBox.Show("Stopped/Unstopped supplier-product",
                               "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadSuppliersProductsBindingSource_Grid();
                }
                else
                {
                    throw new Exception(customResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBoxEditSuppliersProducts_Suppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReloadRemoveSupplierProductBindingSource_Product();
            }
            catch
            {
                return;
            }
        }
        private void btnREMOVESupplierProduct_Click(object sender, EventArgs e)
        {
            if (!GetConfirmation("Are you sure to remove this Entry, this can cause loss of data?", "Confirm Remove!!"))
            {
                return;
            }
            if (!GetConfirmation("Remove this entry pernamently?", "Confirm Remove!!"))
            {
                return;
            }
            try
            {
                CustomResult customResult = bus.RemoveSupplierProduct(
                (int)comboBoxEditSuppliersProducts_Suppliers.SelectedValue,
                (int)comboBoxEditSuppliersProducts_Products.SelectedValue);
                if (customResult.Result == CustomResultType.Succeed)
                {
                    MessageBox.Show("Supplier-Product Removed",
                                "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadSuppliersProductsBindingSource_Grid();
                    ReloadRemoveSupplierProductBindingSource_Supplier();
                    ReloadRemoveSupplierProductBindingSource_Product();
                }
                else
                {
                    throw new Exception(customResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSearchSupplierProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSearchSupplierProductValue.Text)) { ReloadSuppliersProductsBindingSource_Grid();return; }
                string searchOption = (comboBoxSupplierProductSearchOptions.SelectedItem as dynamic).Value;
                if (searchOption == "SupplierId")
                {
                    int id;
                    if (Int32.TryParse(txtSearchSupplierProductValue.Text, out id))
                    {
                        supplierProductDTOBindingSource.DataSource = bus.FindSupplierBySupplierID(id);
                    }
                    else
                    {
                        throw new Exception("Invalid search value");
                    }

                }
                else if (searchOption == "SupplierName")
                {
                    supplierProductDTOBindingSource.DataSource = bus.FindSupplierBySupplierName(txtSearchSupplierProductValue.Text);
                }
                else if(searchOption == "ProductId")
                {
                    int id;
                    if (Int32.TryParse(txtSearchSupplierProductValue.Text, out id))
                    {
                        supplierProductDTOBindingSource.DataSource = bus.FindSupplierByProductId(id);
                    }
                    else
                    {
                        throw new Exception("Invalid search value");
                    }   
                }
                else
                {
                    supplierProductDTOBindingSource.DataSource = bus.FindSupplierByProductName(txtSearchSupplierProductValue.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #endregion


    }

}
