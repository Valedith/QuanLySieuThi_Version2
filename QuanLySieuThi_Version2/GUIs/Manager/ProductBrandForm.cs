using QuanLySieuThi_Version2.BUS;
using QuanLySieuThi_Version2.Infrastructures;
using QuanLySieuThi_Version2.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace QuanLySieuThi_Version2.GUIs.Manager
{
    public partial class ProductBrandForm : Form
    {
        #region Private variables
        ProductBrandBUS productBrandBUS = new ProductBrandBUS();
        Validator validator = new Validator();
        #endregion

        #region Constructors
        public ProductBrandForm()
        {
            InitializeComponent();
            CreateControlDictionary();
            CreateSearchOptionsComboBox();
        }

        #endregion

        #region Private functions
        private void CreateSearchOptionsComboBox()
        {
            comboBoxSearchOptions.DisplayMember = "Text";
            comboBoxSearchOptions.ValueMember = "Value";
            comboBoxSearchOptions.Items.Add(new { Text = "ID", Value = "ID" });
            comboBoxSearchOptions.Items.Add(new { Text = "Name", Value = "Name" });
            comboBoxSearchOptions.SelectedIndex = 0;
        }
        private void CreateControlDictionary()
        {
            validator.AddControlDictionary(typeof(ProductBrand).Name, "Name", txtName);
        }
        private void RefreshProductBrandGrid()
        {
            productBrandDataGridView.Refresh();
        }
        private void ReloadProductBrandBindingSource()
        {
            productBrandBindingSource.DataSource = productBrandBUS.GetAllProductBrands();
        }
        private void ClearAllTextBoxes()
        {
            foreach (TextBox textBox in this.Controls)
            {
                textBox.Clear();
            }
        }
        private void ClearValuesGroupBox()
        {
            txtName.Clear();
            checkBoxIsActive.Checked = true;
        }
        #endregion

        #region Execution Orders
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Bind the categoryBindingSource.DataSource to
            // all the Unchanged, Modified and Added Category objects that
            // are currently tracked by the DbContext.
            // Note that we need to call ToBindingList() on the
            // ObservableCollection<TEntity> returned by
            // the DbSet.Local property to get the BindingList<T>
            // in order to facilitate two-way binding in WinForms.
            try
            {
                this.productBrandBindingSource.DataSource =
                productBrandBUS.GetAllProductBrands();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ActiveControl = txtSearchValue;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            productBrandBUS.Dispose();
            base.OnClosing(e);
        }
        #endregion

        #region Events
        #region Main Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to Add this item ??",
                                       "Confirm Add!!",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.No) { return; }
                ProductBrand productBrand = new ProductBrand(txtName.Text.Trim(), checkBoxIsActive.Checked);
                CustomResult customResult = productBrandBUS.AddProductBrand(productBrand);
                if (customResult.Result == CustomResultType.Succeed)
                {
                    productBrandDataGridView.Refresh();
                    MessageBox.Show("Product Brand Added",
                                "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearValuesGroupBox();
                    RefreshProductBrandGrid();

                    txtName.Focus();
                }
                else if (customResult.Result == CustomResultType.InvalidModelState)
                {
                    validator.DisplayModelValidationErrorsAndFocus(productBrand.GetType());
                }
                else
                {
                    throw new Exception(customResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to Edit this item ??",
                                     "Confirm Edit!!",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.No) { return; }

                ProductBrand productBrand = productBrandBindingSource.Current as ProductBrand;
                if (productBrand == null)
                {
                    throw new Exception("Couldn't get the product brand to edit");
                }
                productBrand.Name = txtName.Text.Trim();
                productBrand.IsActive = checkBoxIsActive.Checked;

                CustomResult customResult = productBrandBUS.EditProductBrand(productBrand);
                if (customResult.Result == CustomResultType.Succeed)
                {
                    RefreshProductBrandGrid();
                    ClearValuesGroupBox();
                    MessageBox.Show("Product Brand Edited",
                                "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (customResult.Result == CustomResultType.InvalidModelState)
                {
                    validator.DisplayModelValidationErrorsAndFocus(productBrand.GetType());
                }
                else
                {
                    throw new Exception(customResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLock_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to Lock this item ??",
                                     "Confirm Lock!!",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.No) { return; }

                var productBrand = productBrandBindingSource.Current as ProductBrand;
                if (productBrand == null)
                {
                    throw new Exception("Couldn't get the product brand to edit");
                }

                int id = productBrand.Id;
                CustomResult customResult = productBrandBUS.ChangeLockProductBrand(id);
                if (customResult.Result == CustomResultType.Succeed)
                {
                    RefreshProductBrandGrid();
                }
                else if (customResult.Result == CustomResultType.InvalidModelState)
                {
                    validator.DisplayModelValidationErrorsAndFocus(typeof(ProductBrand));
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadProductBrandBindingSource();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchValue.Text.Trim())) { return; }
            try
            {
                if ((comboBoxSearchOptions.SelectedItem as dynamic).Value == "ID")
                {
                    int id;
                    if (Int32.TryParse(txtSearchValue.Text, out id))
                    {
                        productBrandBindingSource.DataSource = productBrandBUS.SearchProductBrandByID(id);
                    }
                    else
                    {
                        MessageBox.Show("Invalid search value", "Error"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if ((comboBoxSearchOptions.SelectedItem as dynamic).Value == "Name")
                {
                    productBrandBindingSource.DataSource = productBrandBUS.SearchProductBrandByName(txtSearchValue.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some expected error has ocurred, please contact your administrator\n" +
                                ex.Message, "Error"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void productBrandDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProductBrand productBrand = productBrandBindingSource.Current as ProductBrand;
                txtName.Text = productBrand.Name;
                checkBoxIsActive.Checked = productBrand.IsActive;
            }
            catch
            {
                return;
            }

        }
        //Press enter to search
        private void txtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        #endregion
    }
}
