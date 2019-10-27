namespace QuanLySieuThi_Version2.GUIs.Manager
{
    partial class ProductForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label detailLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label label4;
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelProducts = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxShowLocked = new System.Windows.Forms.CheckBox();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBrandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.splitContainerTypesAndSupplier = new System.Windows.Forms.SplitContainer();
            this.groupBoxProductTypes = new System.Windows.Forms.GroupBox();
            this.productTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumnDeleteSelectedType = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxSuppliers = new System.Windows.Forms.GroupBox();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumnDeleteSelectedSupplier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promotionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelActionButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanelProductsDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.comboBoxProductBrand_Add = new System.Windows.Forms.ComboBox();
            this.productBrandBindingSource_All = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxProductTypes_Add = new System.Windows.Forms.ComboBox();
            this.productTypeBindingSource_All = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSuppliers_Add = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource_All = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddProductType = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            detailLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.groupBoxProducts.SuspendLayout();
            this.tableLayoutPanelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTypesAndSupplier)).BeginInit();
            this.splitContainerTypesAndSupplier.Panel1.SuspendLayout();
            this.splitContainerTypesAndSupplier.Panel2.SuspendLayout();
            this.splitContainerTypesAndSupplier.SuspendLayout();
            this.groupBoxProductTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypesBindingSource)).BeginInit();
            this.groupBoxSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsBindingSource)).BeginInit();
            this.groupBoxActions.SuspendLayout();
            this.tableLayoutPanelActionButtons.SuspendLayout();
            this.tableLayoutPanelProductsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandBindingSource_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 126);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 24);
            label2.TabIndex = 1;
            label2.Text = "Product Types:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel1
            // 
            nameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(259, 54);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(84, 72);
            nameLabel1.TabIndex = 21;
            nameLabel1.Text = "Product Brand:";
            nameLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(259, 126);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 24);
            label3.TabIndex = 21;
            label3.Text = "Suppliers";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            nameLabel.Location = new System.Drawing.Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(84, 24);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name:";
            nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            quantityLabel.Location = new System.Drawing.Point(3, 24);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(84, 30);
            quantityLabel.TabIndex = 24;
            quantityLabel.Text = "Quantity:";
            quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailLabel
            // 
            detailLabel.AutoSize = true;
            detailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            detailLabel.Location = new System.Drawing.Point(3, 54);
            detailLabel.Name = "detailLabel";
            detailLabel.Size = new System.Drawing.Size(84, 72);
            detailLabel.TabIndex = 25;
            detailLabel.Text = "Detail:";
            detailLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            priceLabel.Location = new System.Drawing.Point(259, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(84, 24);
            priceLabel.TabIndex = 26;
            priceLabel.Text = "Price:";
            priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            isActiveLabel.Location = new System.Drawing.Point(63, 0);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(60, 24);
            isActiveLabel.TabIndex = 27;
            isActiveLabel.Text = "Is Active:";
            isActiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(259, 24);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 30);
            label4.TabIndex = 29;
            label4.Text = "Unit:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.tableLayoutPanelProducts);
            this.groupBoxProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxProducts.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(913, 233);
            this.groupBoxProducts.TabIndex = 0;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Products";
            // 
            // tableLayoutPanelProducts
            // 
            this.tableLayoutPanelProducts.ColumnCount = 1;
            this.tableLayoutPanelProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProducts.Controls.Add(this.checkBoxShowLocked, 0, 0);
            this.tableLayoutPanelProducts.Controls.Add(this.productDataGridView, 0, 1);
            this.tableLayoutPanelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProducts.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelProducts.Name = "tableLayoutPanelProducts";
            this.tableLayoutPanelProducts.RowCount = 2;
            this.tableLayoutPanelProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProducts.Size = new System.Drawing.Size(907, 214);
            this.tableLayoutPanelProducts.TabIndex = 1;
            // 
            // checkBoxShowLocked
            // 
            this.checkBoxShowLocked.AutoSize = true;
            this.checkBoxShowLocked.Location = new System.Drawing.Point(3, 3);
            this.checkBoxShowLocked.Name = "checkBoxShowLocked";
            this.checkBoxShowLocked.Size = new System.Drawing.Size(270, 17);
            this.checkBoxShowLocked.TabIndex = 0;
            this.checkBoxShowLocked.Text = "Show Locked Products Types\'s (Brands\'s) Products";
            this.checkBoxShowLocked.UseVisualStyleBackColor = true;
            this.checkBoxShowLocked.CheckedChanged += new System.EventHandler(this.checkBoxShowLocked_CheckedChanged);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToOrderColumns = true;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.Unit,
            this.priceDataGridViewTextBoxColumn,
            this.productBrandNameDataGridViewTextBoxColumn,
            this.detailDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDataGridView.Location = new System.Drawing.Point(3, 28);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.Size = new System.Drawing.Size(901, 183);
            this.productDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 71;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 51;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 56;
            // 
            // productBrandNameDataGridViewTextBoxColumn
            // 
            this.productBrandNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productBrandNameDataGridViewTextBoxColumn.DataPropertyName = "ProductBrandName";
            this.productBrandNameDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.productBrandNameDataGridViewTextBoxColumn.Name = "productBrandNameDataGridViewTextBoxColumn";
            this.productBrandNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productBrandNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // detailDataGridViewTextBoxColumn
            // 
            this.detailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.detailDataGridViewTextBoxColumn.DataPropertyName = "Detail";
            this.detailDataGridViewTextBoxColumn.HeaderText = "Detail";
            this.detailDataGridViewTextBoxColumn.Name = "detailDataGridViewTextBoxColumn";
            this.detailDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailDataGridViewTextBoxColumn.Width = 59;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Width = 51;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(QuanLySieuThi_Version2.Models.Product);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.splitContainerTypesAndSupplier);
            this.groupBoxDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxDetails.Location = new System.Drawing.Point(0, 233);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(395, 445);
            this.groupBoxDetails.TabIndex = 1;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // splitContainerTypesAndSupplier
            // 
            this.splitContainerTypesAndSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTypesAndSupplier.Location = new System.Drawing.Point(3, 16);
            this.splitContainerTypesAndSupplier.Name = "splitContainerTypesAndSupplier";
            this.splitContainerTypesAndSupplier.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTypesAndSupplier.Panel1
            // 
            this.splitContainerTypesAndSupplier.Panel1.Controls.Add(this.groupBoxProductTypes);
            // 
            // splitContainerTypesAndSupplier.Panel2
            // 
            this.splitContainerTypesAndSupplier.Panel2.Controls.Add(this.groupBoxSuppliers);
            this.splitContainerTypesAndSupplier.Size = new System.Drawing.Size(389, 426);
            this.splitContainerTypesAndSupplier.SplitterDistance = 206;
            this.splitContainerTypesAndSupplier.TabIndex = 3;
            // 
            // groupBoxProductTypes
            // 
            this.groupBoxProductTypes.Controls.Add(this.productTypesDataGridView);
            this.groupBoxProductTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProductTypes.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProductTypes.Name = "groupBoxProductTypes";
            this.groupBoxProductTypes.Size = new System.Drawing.Size(389, 206);
            this.groupBoxProductTypes.TabIndex = 0;
            this.groupBoxProductTypes.TabStop = false;
            this.groupBoxProductTypes.Text = "Product Types";
            // 
            // productTypesDataGridView
            // 
            this.productTypesDataGridView.AllowUserToAddRows = false;
            this.productTypesDataGridView.AllowUserToOrderColumns = true;
            this.productTypesDataGridView.AutoGenerateColumns = false;
            this.productTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumnDeleteSelectedType,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn2});
            this.productTypesDataGridView.DataSource = this.productTypesBindingSource;
            this.productTypesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTypesDataGridView.Location = new System.Drawing.Point(3, 16);
            this.productTypesDataGridView.Name = "productTypesDataGridView";
            this.productTypesDataGridView.ReadOnly = true;
            this.productTypesDataGridView.Size = new System.Drawing.Size(383, 187);
            this.productTypesDataGridView.TabIndex = 0;
            this.productTypesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productTypesDataGridView_CellContentClick);
            // 
            // dataGridViewButtonColumnDeleteSelectedType
            // 
            this.dataGridViewButtonColumnDeleteSelectedType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewButtonColumnDeleteSelectedType.HeaderText = "";
            this.dataGridViewButtonColumnDeleteSelectedType.Name = "dataGridViewButtonColumnDeleteSelectedType";
            this.dataGridViewButtonColumnDeleteSelectedType.ReadOnly = true;
            this.dataGridViewButtonColumnDeleteSelectedType.Text = "Delete";
            this.dataGridViewButtonColumnDeleteSelectedType.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumnDeleteSelectedType.Width = 5;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 41;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn2.HeaderText = "IsActive";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 51;
            // 
            // productTypesBindingSource
            // 
            this.productTypesBindingSource.DataMember = "ProductTypes";
            this.productTypesBindingSource.DataSource = this.productBindingSource;
            // 
            // groupBoxSuppliers
            // 
            this.groupBoxSuppliers.Controls.Add(this.suppliersDataGridView);
            this.groupBoxSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSuppliers.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSuppliers.Name = "groupBoxSuppliers";
            this.groupBoxSuppliers.Size = new System.Drawing.Size(389, 216);
            this.groupBoxSuppliers.TabIndex = 0;
            this.groupBoxSuppliers.TabStop = false;
            this.groupBoxSuppliers.Text = "Suppliers";
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.AllowUserToAddRows = false;
            this.suppliersDataGridView.AllowUserToOrderColumns = true;
            this.suppliersDataGridView.AutoGenerateColumns = false;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumnDeleteSelectedSupplier,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewCheckBoxColumn3});
            this.suppliersDataGridView.DataSource = this.suppliersBindingSource;
            this.suppliersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersDataGridView.Location = new System.Drawing.Point(3, 16);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.ReadOnly = true;
            this.suppliersDataGridView.Size = new System.Drawing.Size(383, 197);
            this.suppliersDataGridView.TabIndex = 0;
            // 
            // dataGridViewButtonColumnDeleteSelectedSupplier
            // 
            this.dataGridViewButtonColumnDeleteSelectedSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewButtonColumnDeleteSelectedSupplier.HeaderText = "";
            this.dataGridViewButtonColumnDeleteSelectedSupplier.Name = "dataGridViewButtonColumnDeleteSelectedSupplier";
            this.dataGridViewButtonColumnDeleteSelectedSupplier.ReadOnly = true;
            this.dataGridViewButtonColumnDeleteSelectedSupplier.Text = "Delete";
            this.dataGridViewButtonColumnDeleteSelectedSupplier.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumnDeleteSelectedSupplier.Width = 5;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 41;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn11.HeaderText = "Name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 60;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn12.HeaderText = "Address";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 70;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn13.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn3.HeaderText = "IsActive";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Width = 51;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.productBindingSource;
            // 
            // promotionsBindingSource
            // 
            this.promotionsBindingSource.DataMember = "Promotions";
            this.promotionsBindingSource.DataSource = this.productBindingSource;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.tableLayoutPanelActionButtons);
            this.groupBoxActions.Controls.Add(this.tableLayoutPanelProductsDetail);
            this.groupBoxActions.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxActions.Location = new System.Drawing.Point(395, 233);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(518, 445);
            this.groupBoxActions.TabIndex = 2;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // tableLayoutPanelActionButtons
            // 
            this.tableLayoutPanelActionButtons.ColumnCount = 4;
            this.tableLayoutPanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanelActionButtons.Controls.Add(this.btnDELETE, 3, 0);
            this.tableLayoutPanelActionButtons.Controls.Add(this.btnAddProduct, 0, 0);
            this.tableLayoutPanelActionButtons.Controls.Add(this.btnSaveChanges, 1, 0);
            this.tableLayoutPanelActionButtons.Controls.Add(this.btnRefresh, 2, 0);
            this.tableLayoutPanelActionButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelActionButtons.Location = new System.Drawing.Point(3, 224);
            this.tableLayoutPanelActionButtons.Name = "tableLayoutPanelActionButtons";
            this.tableLayoutPanelActionButtons.RowCount = 1;
            this.tableLayoutPanelActionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelActionButtons.Size = new System.Drawing.Size(512, 32);
            this.tableLayoutPanelActionButtons.TabIndex = 5;
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.DarkRed;
            this.btnDELETE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDELETE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDELETE.Location = new System.Drawing.Point(419, 3);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(90, 26);
            this.btnDELETE.TabIndex = 6;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(122, 26);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveChanges.Location = new System.Drawing.Point(131, 3);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(122, 26);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(259, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(154, 26);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh/Discard Changes";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableLayoutPanelProductsDetail
            // 
            this.tableLayoutPanelProductsDetail.ColumnCount = 4;
            this.tableLayoutPanelProductsDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelProductsDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProductsDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelProductsDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProductsDetail.Controls.Add(label4, 2, 1);
            this.tableLayoutPanelProductsDetail.Controls.Add(priceLabel, 2, 0);
            this.tableLayoutPanelProductsDetail.Controls.Add(detailLabel, 0, 2);
            this.tableLayoutPanelProductsDetail.Controls.Add(this.txtDetail, 1, 2);
            this.tableLayoutPanelProductsDetail.Controls.Add(quantityLabel, 0, 1);
            this.tableLayoutPanelProductsDetail.Controls.Add(this.numQuantity, 1, 1);
            this.tableLayoutPanelProductsDetail.Controls.Add(nameLabel, 0, 0);
            this.tableLayoutPanelProductsDetail.Controls.Add(this.txtProductName, 1, 0);
            this.tableLayoutPanelProductsDetail.Controls.Add(label3, 2, 3);
            this.tableLayoutPanelProductsDetail.Controls.Add(nameLabel1, 2, 2);
            this.tableLayoutPanelProductsDetail.Controls.Add(label2, 0, 3);
            this.tableLayoutPanelProductsDetail.Controls.Add(this.comboBoxProductBrand_Add, 3, 2);
            this.tableLayoutPanelProductsDetail.Controls.Add(this.comboBoxProductTypes_Add, 1, 3);
            this.tableLayoutPanelProductsDetail.Controls.Add(this.comboBoxSuppliers_Add, 3, 3);
            this.tableLayoutPanelProductsDetail.Controls.Add(this.btnAddProductType, 1, 4);
            this.tableLayoutPanelProductsDetail.Controls.Add(this.btnAddSupplier, 3, 4);
            this.tableLayoutPanelProductsDetail.Controls.Add(this.numPrice, 3, 0);
            this.tableLayoutPanelProductsDetail.Controls.Add(this.tableLayoutPanel2, 3, 1);
            this.tableLayoutPanelProductsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelProductsDetail.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanelProductsDetail.Name = "tableLayoutPanelProductsDetail";
            this.tableLayoutPanelProductsDetail.RowCount = 5;
            this.tableLayoutPanelProductsDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanelProductsDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelProductsDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanelProductsDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanelProductsDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelProductsDetail.Size = new System.Drawing.Size(512, 182);
            this.tableLayoutPanelProductsDetail.TabIndex = 3;
            // 
            // txtDetail
            // 
            this.txtDetail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Detail", true));
            this.txtDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetail.Location = new System.Drawing.Point(93, 57);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetail.Size = new System.Drawing.Size(160, 66);
            this.txtDetail.TabIndex = 26;
            // 
            // numQuantity
            // 
            this.numQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Quantity", true));
            this.numQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numQuantity.Location = new System.Drawing.Point(93, 27);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(160, 20);
            this.numQuantity.TabIndex = 25;
            // 
            // txtProductName
            // 
            this.txtProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductName.Location = new System.Drawing.Point(93, 3);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(160, 20);
            this.txtProductName.TabIndex = 24;
            // 
            // comboBoxProductBrand_Add
            // 
            this.comboBoxProductBrand_Add.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductBrand.Name", true));
            this.comboBoxProductBrand_Add.DataSource = this.productBrandBindingSource_All;
            this.comboBoxProductBrand_Add.DisplayMember = "Name";
            this.comboBoxProductBrand_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxProductBrand_Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductBrand_Add.FormattingEnabled = true;
            this.comboBoxProductBrand_Add.Location = new System.Drawing.Point(349, 57);
            this.comboBoxProductBrand_Add.Name = "comboBoxProductBrand_Add";
            this.comboBoxProductBrand_Add.Size = new System.Drawing.Size(160, 21);
            this.comboBoxProductBrand_Add.TabIndex = 22;
            this.comboBoxProductBrand_Add.ValueMember = "Id";
            // 
            // productBrandBindingSource_All
            // 
            this.productBrandBindingSource_All.DataSource = typeof(QuanLySieuThi_Version2.Models.ProductBrand);
            // 
            // comboBoxProductTypes_Add
            // 
            this.comboBoxProductTypes_Add.DataSource = this.productTypeBindingSource_All;
            this.comboBoxProductTypes_Add.DisplayMember = "Name";
            this.comboBoxProductTypes_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProductTypes_Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductTypes_Add.FormattingEnabled = true;
            this.comboBoxProductTypes_Add.Location = new System.Drawing.Point(93, 129);
            this.comboBoxProductTypes_Add.Name = "comboBoxProductTypes_Add";
            this.comboBoxProductTypes_Add.Size = new System.Drawing.Size(160, 21);
            this.comboBoxProductTypes_Add.TabIndex = 23;
            this.comboBoxProductTypes_Add.ValueMember = "Id";
            // 
            // productTypeBindingSource_All
            // 
            this.productTypeBindingSource_All.DataSource = typeof(QuanLySieuThi_Version2.Models.ProductType);
            // 
            // comboBoxSuppliers_Add
            // 
            this.comboBoxSuppliers_Add.DataSource = this.supplierBindingSource_All;
            this.comboBoxSuppliers_Add.DisplayMember = "Name";
            this.comboBoxSuppliers_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSuppliers_Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuppliers_Add.FormattingEnabled = true;
            this.comboBoxSuppliers_Add.Location = new System.Drawing.Point(349, 129);
            this.comboBoxSuppliers_Add.Name = "comboBoxSuppliers_Add";
            this.comboBoxSuppliers_Add.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSuppliers_Add.TabIndex = 23;
            this.comboBoxSuppliers_Add.ValueMember = "Id";
            // 
            // supplierBindingSource_All
            // 
            this.supplierBindingSource_All.DataSource = typeof(QuanLySieuThi_Version2.Models.Supplier);
            // 
            // btnAddProductType
            // 
            this.btnAddProductType.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddProductType.Location = new System.Drawing.Point(178, 153);
            this.btnAddProductType.Name = "btnAddProductType";
            this.btnAddProductType.Size = new System.Drawing.Size(75, 26);
            this.btnAddProductType.TabIndex = 29;
            this.btnAddProductType.Text = "Add Type";
            this.btnAddProductType.UseVisualStyleBackColor = true;
            this.btnAddProductType.Click += new System.EventHandler(this.btnAddProductType_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddSupplier.Location = new System.Drawing.Point(434, 153);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(75, 26);
            this.btnAddSupplier.TabIndex = 29;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // numPrice
            // 
            this.numPrice.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Price", true));
            this.numPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPrice.Location = new System.Drawing.Point(349, 3);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(160, 20);
            this.numPrice.TabIndex = 30;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.27273F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.72727F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Controls.Add(this.isActiveCheckBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(isActiveLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtUnit, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(349, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(160, 24);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "IsActive", true));
            this.isActiveCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isActiveCheckBox.Location = new System.Drawing.Point(129, 3);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(28, 18);
            this.isActiveCheckBox.TabIndex = 28;
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtUnit
            // 
            this.txtUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Unit", true));
            this.txtUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUnit.Location = new System.Drawing.Point(3, 3);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(54, 20);
            this.txtUnit.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.11316F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.63972F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.24711F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 26);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(53, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(416, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 20);
            this.button5.TabIndex = 3;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(913, 678);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxProducts);
            this.Name = "ProductForm";
            this.Text = "Product Forms";
            this.groupBoxProducts.ResumeLayout(false);
            this.tableLayoutPanelProducts.ResumeLayout(false);
            this.tableLayoutPanelProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            this.splitContainerTypesAndSupplier.Panel1.ResumeLayout(false);
            this.splitContainerTypesAndSupplier.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTypesAndSupplier)).EndInit();
            this.splitContainerTypesAndSupplier.ResumeLayout(false);
            this.groupBoxProductTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productTypesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypesBindingSource)).EndInit();
            this.groupBoxSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsBindingSource)).EndInit();
            this.groupBoxActions.ResumeLayout(false);
            this.tableLayoutPanelActionButtons.ResumeLayout(false);
            this.tableLayoutPanelProductsDetail.ResumeLayout(false);
            this.tableLayoutPanelProductsDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandBindingSource_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.SplitContainer splitContainerTypesAndSupplier;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.GroupBox groupBoxProductTypes;
        private System.Windows.Forms.DataGridView productTypesDataGridView;
        private System.Windows.Forms.BindingSource productTypesBindingSource;
        private System.Windows.Forms.GroupBox groupBoxSuppliers;
        private System.Windows.Forms.DataGridView suppliersDataGridView;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.BindingSource promotionsBindingSource;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.CheckBox checkBoxShowLocked;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelActionButtons;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.BindingSource productTypeBindingSource_All;
        private System.Windows.Forms.BindingSource supplierBindingSource_All;
        private System.Windows.Forms.BindingSource productBrandBindingSource_All;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProductsDetail;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox comboBoxProductBrand_Add;
        private System.Windows.Forms.ComboBox comboBoxProductTypes_Add;
        private System.Windows.Forms.ComboBox comboBoxSuppliers_Add;
        private System.Windows.Forms.Button btnAddProductType;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumnDeleteSelectedType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBrandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumnDeleteSelectedSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
    }
}