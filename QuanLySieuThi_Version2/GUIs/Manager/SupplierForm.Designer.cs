namespace QuanLySieuThi_Version2.GUIs.Manager
{
    partial class SupplierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label label1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxSupplierActions = new System.Windows.Forms.GroupBox();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.comboBoxSearchOptions = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnRefreshSupplier = new System.Windows.Forms.Button();
            this.btnLockSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.txtSupplierPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.suppliersProductsDataGridView = new QuanLySieuThi_Version2.Infrastructures.CustomDataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersProductsBindingSource_Grid = new System.Windows.Forms.BindingSource(this.components);
            this.supplierDataGridView = new QuanLySieuThi_Version2.Infrastructures.CustomDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAddSuppliersProducts_Supplier = new System.Windows.Forms.ComboBox();
            this.comboBoxAddSuppliersProducts_Products = new System.Windows.Forms.ComboBox();
            this.btnAddSuppliersProducts = new System.Windows.Forms.Button();
            this.comboBoxEditSuppliersProducts_Products = new System.Windows.Forms.ComboBox();
            this.comboBoxEditSuppliersProducts_Suppliers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.addSuppliersProductsBindingSource_Products = new System.Windows.Forms.BindingSource(this.components);
            this.addSuppliersProductsBindingSource_Suppliers = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            addressLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxSupplierActions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersProductsBindingSource_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addSuppliersProductsBindingSource_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSuppliersProductsBindingSource_Suppliers)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 75);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(9, 176);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(51, 13);
            isActiveLabel.TabIndex = 4;
            isActiveLabel.Text = "Is Active:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 25);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(19, 143);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(41, 13);
            phoneNumberLabel.TabIndex = 8;
            phoneNumberLabel.Text = "Phone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 254);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 13);
            label1.TabIndex = 18;
            label1.Text = "Search:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.supplierDataGridView);
            this.groupBox1.Controls.Add(this.groupBoxSupplierActions);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1066, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            // 
            // groupBoxSupplierActions
            // 
            this.groupBoxSupplierActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSupplierActions.Controls.Add(this.btnSearchSupplier);
            this.groupBoxSupplierActions.Controls.Add(this.comboBoxSearchOptions);
            this.groupBoxSupplierActions.Controls.Add(label1);
            this.groupBoxSupplierActions.Controls.Add(this.txtSearchValue);
            this.groupBoxSupplierActions.Controls.Add(this.btnRefreshSupplier);
            this.groupBoxSupplierActions.Controls.Add(this.btnLockSupplier);
            this.groupBoxSupplierActions.Controls.Add(this.btnEditSupplier);
            this.groupBoxSupplierActions.Controls.Add(this.btnAddSupplier);
            this.groupBoxSupplierActions.Controls.Add(this.checkBoxIsActive);
            this.groupBoxSupplierActions.Controls.Add(this.txtSupplierPhoneNumber);
            this.groupBoxSupplierActions.Controls.Add(this.txtSupplierAddress);
            this.groupBoxSupplierActions.Controls.Add(this.txtSupplierName);
            this.groupBoxSupplierActions.Controls.Add(addressLabel);
            this.groupBoxSupplierActions.Controls.Add(isActiveLabel);
            this.groupBoxSupplierActions.Controls.Add(nameLabel);
            this.groupBoxSupplierActions.Controls.Add(phoneNumberLabel);
            this.groupBoxSupplierActions.Location = new System.Drawing.Point(6, 19);
            this.groupBoxSupplierActions.Name = "groupBoxSupplierActions";
            this.groupBoxSupplierActions.Size = new System.Drawing.Size(361, 289);
            this.groupBoxSupplierActions.TabIndex = 1;
            this.groupBoxSupplierActions.TabStop = false;
            this.groupBoxSupplierActions.Text = "Actions";
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.Location = new System.Drawing.Point(287, 249);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(57, 23);
            this.btnSearchSupplier.TabIndex = 2;
            this.btnSearchSupplier.Text = "Search";
            this.btnSearchSupplier.UseVisualStyleBackColor = true;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // comboBoxSearchOptions
            // 
            this.comboBoxSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchOptions.FormattingEnabled = true;
            this.comboBoxSearchOptions.Location = new System.Drawing.Point(202, 250);
            this.comboBoxSearchOptions.Name = "comboBoxSearchOptions";
            this.comboBoxSearchOptions.Size = new System.Drawing.Size(79, 21);
            this.comboBoxSearchOptions.TabIndex = 1;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(56, 251);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(140, 20);
            this.txtSearchValue.TabIndex = 0;
            this.txtSearchValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchValue_KeyDown);
            // 
            // btnRefreshSupplier
            // 
            this.btnRefreshSupplier.Location = new System.Drawing.Point(269, 209);
            this.btnRefreshSupplier.Name = "btnRefreshSupplier";
            this.btnRefreshSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshSupplier.TabIndex = 10;
            this.btnRefreshSupplier.Text = "Refresh";
            this.btnRefreshSupplier.UseVisualStyleBackColor = true;
            this.btnRefreshSupplier.Click += new System.EventHandler(this.btnRefreshSupplier_Click);
            // 
            // btnLockSupplier
            // 
            this.btnLockSupplier.Location = new System.Drawing.Point(168, 209);
            this.btnLockSupplier.Name = "btnLockSupplier";
            this.btnLockSupplier.Size = new System.Drawing.Size(95, 23);
            this.btnLockSupplier.TabIndex = 9;
            this.btnLockSupplier.Text = "Lock/Unlock";
            this.btnLockSupplier.UseVisualStyleBackColor = true;
            this.btnLockSupplier.Click += new System.EventHandler(this.btnLockSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Location = new System.Drawing.Point(87, 209);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnEditSupplier.TabIndex = 8;
            this.btnEditSupplier.Text = "Edit";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(6, 209);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddSupplier.TabIndex = 7;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Location = new System.Drawing.Point(66, 176);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsActive.TabIndex = 6;
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // txtSupplierPhoneNumber
            // 
            this.txtSupplierPhoneNumber.Location = new System.Drawing.Point(66, 143);
            this.txtSupplierPhoneNumber.Name = "txtSupplierPhoneNumber";
            this.txtSupplierPhoneNumber.Size = new System.Drawing.Size(197, 20);
            this.txtSupplierPhoneNumber.TabIndex = 5;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(66, 75);
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(278, 56);
            this.txtSupplierAddress.TabIndex = 4;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(66, 25);
            this.txtSupplierName.Multiline = true;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(278, 39);
            this.txtSupplierName.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.suppliersProductsDataGridView);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1066, 369);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supplier Details";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 342);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // suppliersProductsDataGridView
            // 
            this.suppliersProductsDataGridView.AllowUserToAddRows = false;
            this.suppliersProductsDataGridView.AllowUserToDeleteRows = false;
            this.suppliersProductsDataGridView.AllowUserToOrderColumns = true;
            this.suppliersProductsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suppliersProductsDataGridView.AutoGenerateColumns = false;
            this.suppliersProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.suppliersProductsDataGridView.DataSource = this.suppliersProductsBindingSource_Grid;
            this.suppliersProductsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.suppliersProductsDataGridView.Location = new System.Drawing.Point(382, 19);
            this.suppliersProductsDataGridView.Name = "suppliersProductsDataGridView";
            this.suppliersProductsDataGridView.ReadOnly = true;
            this.suppliersProductsDataGridView.Size = new System.Drawing.Size(678, 342);
            this.suppliersProductsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SupplierName";
            this.dataGridViewTextBoxColumn7.HeaderText = "SupplierName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn8.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // suppliersProductsBindingSource_Grid
            // 
            this.suppliersProductsBindingSource_Grid.DataSource = typeof(QuanLySieuThi_Version2.Models.DTOs.SuppliersProducts);
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.AllowUserToAddRows = false;
            this.supplierDataGridView.AllowUserToDeleteRows = false;
            this.supplierDataGridView.AllowUserToOrderColumns = true;
            this.supplierDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierDataGridView.AutoGenerateColumns = false;
            this.supplierDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.supplierDataGridView.DataSource = this.supplierBindingSource;
            this.supplierDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.supplierDataGridView.Location = new System.Drawing.Point(382, 19);
            this.supplierDataGridView.MultiSelect = false;
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.ReadOnly = true;
            this.supplierDataGridView.Size = new System.Drawing.Size(678, 289);
            this.supplierDataGridView.TabIndex = 11;
            this.supplierDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsActive";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 51;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(QuanLySieuThi_Version2.Models.Supplier);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddSuppliersProducts);
            this.groupBox2.Controls.Add(this.comboBoxAddSuppliersProducts_Products);
            this.groupBox2.Controls.Add(this.comboBoxAddSuppliersProducts_Supplier);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 124);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.comboBoxEditSuppliersProducts_Products);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.comboBoxEditSuppliersProducts_Suppliers);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(12, 146);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 126);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Remove";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Supplier:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product:";
            // 
            // comboBoxAddSuppliersProducts_Supplier
            // 
            this.comboBoxAddSuppliersProducts_Supplier.DataSource = this.addSuppliersProductsBindingSource_Suppliers;
            this.comboBoxAddSuppliersProducts_Supplier.DisplayMember = "Name";
            this.comboBoxAddSuppliersProducts_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddSuppliersProducts_Supplier.FormattingEnabled = true;
            this.comboBoxAddSuppliersProducts_Supplier.Location = new System.Drawing.Point(64, 23);
            this.comboBoxAddSuppliersProducts_Supplier.Name = "comboBoxAddSuppliersProducts_Supplier";
            this.comboBoxAddSuppliersProducts_Supplier.Size = new System.Drawing.Size(256, 21);
            this.comboBoxAddSuppliersProducts_Supplier.TabIndex = 2;
            this.comboBoxAddSuppliersProducts_Supplier.ValueMember = "Id";
            // 
            // comboBoxAddSuppliersProducts_Products
            // 
            this.comboBoxAddSuppliersProducts_Products.DataSource = this.addSuppliersProductsBindingSource_Products;
            this.comboBoxAddSuppliersProducts_Products.DisplayMember = "Name";
            this.comboBoxAddSuppliersProducts_Products.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddSuppliersProducts_Products.FormattingEnabled = true;
            this.comboBoxAddSuppliersProducts_Products.Location = new System.Drawing.Point(64, 59);
            this.comboBoxAddSuppliersProducts_Products.Name = "comboBoxAddSuppliersProducts_Products";
            this.comboBoxAddSuppliersProducts_Products.Size = new System.Drawing.Size(256, 21);
            this.comboBoxAddSuppliersProducts_Products.TabIndex = 3;
            this.comboBoxAddSuppliersProducts_Products.ValueMember = "Id";
            // 
            // btnAddSuppliersProducts
            // 
            this.btnAddSuppliersProducts.Location = new System.Drawing.Point(254, 89);
            this.btnAddSuppliersProducts.Name = "btnAddSuppliersProducts";
            this.btnAddSuppliersProducts.Size = new System.Drawing.Size(75, 23);
            this.btnAddSuppliersProducts.TabIndex = 4;
            this.btnAddSuppliersProducts.Text = "Add";
            this.btnAddSuppliersProducts.UseVisualStyleBackColor = true;
            this.btnAddSuppliersProducts.Click += new System.EventHandler(this.btnAddSuppliersProducts_Click);
            // 
            // comboBoxEditSuppliersProducts_Products
            // 
            this.comboBoxEditSuppliersProducts_Products.DataSource = this.suppliersProductsBindingSource_Grid;
            this.comboBoxEditSuppliersProducts_Products.DisplayMember = "ProductName";
            this.comboBoxEditSuppliersProducts_Products.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditSuppliersProducts_Products.FormattingEnabled = true;
            this.comboBoxEditSuppliersProducts_Products.Location = new System.Drawing.Point(64, 65);
            this.comboBoxEditSuppliersProducts_Products.Name = "comboBoxEditSuppliersProducts_Products";
            this.comboBoxEditSuppliersProducts_Products.Size = new System.Drawing.Size(256, 21);
            this.comboBoxEditSuppliersProducts_Products.TabIndex = 8;
            this.comboBoxEditSuppliersProducts_Products.ValueMember = "ProductId";
            // 
            // comboBoxEditSuppliersProducts_Suppliers
            // 
            this.comboBoxEditSuppliersProducts_Suppliers.DataSource = this.suppliersProductsBindingSource_Grid;
            this.comboBoxEditSuppliersProducts_Suppliers.DisplayMember = "SupplierName";
            this.comboBoxEditSuppliersProducts_Suppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditSuppliersProducts_Suppliers.FormattingEnabled = true;
            this.comboBoxEditSuppliersProducts_Suppliers.Location = new System.Drawing.Point(64, 29);
            this.comboBoxEditSuppliersProducts_Suppliers.Name = "comboBoxEditSuppliersProducts_Suppliers";
            this.comboBoxEditSuppliersProducts_Suppliers.Size = new System.Drawing.Size(256, 21);
            this.comboBoxEditSuppliersProducts_Suppliers.TabIndex = 7;
            this.comboBoxEditSuppliersProducts_Suppliers.ValueMember = "SupplierId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Supplier:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.ForeColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(254, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "REMOVE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // addSuppliersProductsBindingSource_Products
            // 
            this.addSuppliersProductsBindingSource_Products.DataSource = typeof(QuanLySieuThi_Version2.Models.Product);
            // 
            // addSuppliersProductsBindingSource_Suppliers
            // 
            this.addSuppliersProductsBindingSource_Suppliers.DataSource = typeof(QuanLySieuThi_Version2.Models.Supplier);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.comboBox6);
            this.groupBox6.Controls.Add(this.comboBox5);
            this.groupBox6.Location = new System.Drawing.Point(12, 278);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(335, 54);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(10, 19);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(157, 21);
            this.comboBox5.TabIndex = 12;
            this.comboBox5.ValueMember = "ProductId";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(173, 19);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(81, 21);
            this.comboBox6.TabIndex = 13;
            this.comboBox6.ValueMember = "ProductId";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 706);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxSupplierActions.ResumeLayout(false);
            this.groupBoxSupplierActions.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersProductsBindingSource_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addSuppliersProductsBindingSource_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSuppliersProductsBindingSource_Suppliers)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource suppliersProductsBindingSource_Grid;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private Infrastructures.CustomDataGridView supplierDataGridView;
        private System.Windows.Forms.GroupBox groupBoxSupplierActions;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox groupBox4;
        private Infrastructures.CustomDataGridView suppliersProductsDataGridView;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.TextBox txtSupplierPhoneNumber;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnRefreshSupplier;
        private System.Windows.Forms.Button btnLockSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.ComboBox comboBoxSearchOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxEditSuppliersProducts_Products;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEditSuppliersProducts_Suppliers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddSuppliersProducts;
        private System.Windows.Forms.ComboBox comboBoxAddSuppliersProducts_Products;
        private System.Windows.Forms.BindingSource addSuppliersProductsBindingSource_Products;
        private System.Windows.Forms.ComboBox comboBoxAddSuppliersProducts_Supplier;
        private System.Windows.Forms.BindingSource addSuppliersProductsBindingSource_Suppliers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}