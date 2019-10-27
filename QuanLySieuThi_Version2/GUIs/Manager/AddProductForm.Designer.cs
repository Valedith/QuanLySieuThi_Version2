namespace QuanLySieuThi_Version2.GUIs.Manager
{
    partial class AddProductForm
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
            System.Windows.Forms.Label label1;
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelActionButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanelAddTypesAndSupplier = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxSelectedTypes = new System.Windows.Forms.GroupBox();
            this.dataGridViewSelectedTypes = new System.Windows.Forms.DataGridView();
            this.dataGridViewColumnSelectedTypesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumnSelectedTypesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumnDeleteSelectedType = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxSelectedSuppliers = new System.Windows.Forms.GroupBox();
            this.dataGridViewSelectedSuppliers = new System.Windows.Forms.DataGridView();
            this.dataGridViewColumnSelectedSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumnSelectedSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewColumnSelectedSupplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumnDeleteSelectedSupplier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanelProductsDetail = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
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
            this.btnAddAndClose = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            detailLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBoxActions.SuspendLayout();
            this.tableLayoutPanelActionButtons.SuspendLayout();
            this.tableLayoutPanelAddTypesAndSupplier.SuspendLayout();
            this.groupBoxSelectedTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedTypes)).BeginInit();
            this.groupBoxSelectedSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedSuppliers)).BeginInit();
            this.tableLayoutPanelProductsDetail.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandBindingSource_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 25);
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
            nameLabel1.Location = new System.Drawing.Point(456, 56);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(84, 69);
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
            label3.Location = new System.Drawing.Point(456, 125);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 25);
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
            nameLabel.Size = new System.Drawing.Size(84, 25);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name:";
            nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            quantityLabel.Location = new System.Drawing.Point(3, 25);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(84, 31);
            quantityLabel.TabIndex = 24;
            quantityLabel.Text = "Quantity:";
            quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailLabel
            // 
            detailLabel.AutoSize = true;
            detailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            detailLabel.Location = new System.Drawing.Point(3, 56);
            detailLabel.Name = "detailLabel";
            detailLabel.Size = new System.Drawing.Size(84, 69);
            detailLabel.TabIndex = 25;
            detailLabel.Text = "Detail:";
            detailLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            priceLabel.Location = new System.Drawing.Point(456, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(84, 25);
            priceLabel.TabIndex = 26;
            priceLabel.Text = "Price:";
            priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            isActiveLabel.Location = new System.Drawing.Point(126, 0);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(109, 25);
            isActiveLabel.TabIndex = 27;
            isActiveLabel.Text = "Is Active:";
            isActiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(456, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 31);
            label1.TabIndex = 29;
            label1.Text = "Unit:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.tableLayoutPanelActionButtons);
            this.groupBoxActions.Controls.Add(this.tableLayoutPanelAddTypesAndSupplier);
            this.groupBoxActions.Controls.Add(this.tableLayoutPanelProductsDetail);
            this.groupBoxActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxActions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(913, 417);
            this.groupBoxActions.TabIndex = 2;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // tableLayoutPanelActionButtons
            // 
            this.tableLayoutPanelActionButtons.ColumnCount = 4;
            this.tableLayoutPanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelActionButtons.Controls.Add(this.btnAddAndClose, 0, 0);
            this.tableLayoutPanelActionButtons.Controls.Add(this.btnAddProduct, 0, 0);
            this.tableLayoutPanelActionButtons.Controls.Add(this.btnRefresh, 3, 0);
            this.tableLayoutPanelActionButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelActionButtons.Location = new System.Drawing.Point(3, 354);
            this.tableLayoutPanelActionButtons.Name = "tableLayoutPanelActionButtons";
            this.tableLayoutPanelActionButtons.RowCount = 1;
            this.tableLayoutPanelActionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelActionButtons.Size = new System.Drawing.Size(907, 32);
            this.tableLayoutPanelActionButtons.TabIndex = 5;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(220, 26);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(681, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(223, 26);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableLayoutPanelAddTypesAndSupplier
            // 
            this.tableLayoutPanelAddTypesAndSupplier.ColumnCount = 2;
            this.tableLayoutPanelAddTypesAndSupplier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddTypesAndSupplier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddTypesAndSupplier.Controls.Add(this.groupBoxSelectedTypes, 0, 0);
            this.tableLayoutPanelAddTypesAndSupplier.Controls.Add(this.groupBoxSelectedSuppliers, 1, 0);
            this.tableLayoutPanelAddTypesAndSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelAddTypesAndSupplier.Location = new System.Drawing.Point(3, 198);
            this.tableLayoutPanelAddTypesAndSupplier.Name = "tableLayoutPanelAddTypesAndSupplier";
            this.tableLayoutPanelAddTypesAndSupplier.RowCount = 1;
            this.tableLayoutPanelAddTypesAndSupplier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddTypesAndSupplier.Size = new System.Drawing.Size(907, 156);
            this.tableLayoutPanelAddTypesAndSupplier.TabIndex = 4;
            // 
            // groupBoxSelectedTypes
            // 
            this.groupBoxSelectedTypes.Controls.Add(this.dataGridViewSelectedTypes);
            this.groupBoxSelectedTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSelectedTypes.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelectedTypes.Name = "groupBoxSelectedTypes";
            this.groupBoxSelectedTypes.Size = new System.Drawing.Size(447, 150);
            this.groupBoxSelectedTypes.TabIndex = 0;
            this.groupBoxSelectedTypes.TabStop = false;
            this.groupBoxSelectedTypes.Text = "Selected Types";
            // 
            // dataGridViewSelectedTypes
            // 
            this.dataGridViewSelectedTypes.AllowUserToAddRows = false;
            this.dataGridViewSelectedTypes.AllowUserToDeleteRows = false;
            this.dataGridViewSelectedTypes.AllowUserToOrderColumns = true;
            this.dataGridViewSelectedTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewColumnSelectedTypesId,
            this.dataGridViewColumnSelectedTypesName,
            this.dataGridViewButtonColumnDeleteSelectedType});
            this.dataGridViewSelectedTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelectedTypes.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewSelectedTypes.Name = "dataGridViewSelectedTypes";
            this.dataGridViewSelectedTypes.ReadOnly = true;
            this.dataGridViewSelectedTypes.Size = new System.Drawing.Size(441, 131);
            this.dataGridViewSelectedTypes.TabIndex = 0;
            this.dataGridViewSelectedTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSelectedTypes_CellContentClick);
            // 
            // dataGridViewColumnSelectedTypesId
            // 
            this.dataGridViewColumnSelectedTypesId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewColumnSelectedTypesId.HeaderText = "Id";
            this.dataGridViewColumnSelectedTypesId.Name = "dataGridViewColumnSelectedTypesId";
            this.dataGridViewColumnSelectedTypesId.ReadOnly = true;
            this.dataGridViewColumnSelectedTypesId.Width = 41;
            // 
            // dataGridViewColumnSelectedTypesName
            // 
            this.dataGridViewColumnSelectedTypesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnSelectedTypesName.HeaderText = "Name";
            this.dataGridViewColumnSelectedTypesName.Name = "dataGridViewColumnSelectedTypesName";
            this.dataGridViewColumnSelectedTypesName.ReadOnly = true;
            // 
            // dataGridViewButtonColumnDeleteSelectedType
            // 
            this.dataGridViewButtonColumnDeleteSelectedType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewButtonColumnDeleteSelectedType.HeaderText = "Delete";
            this.dataGridViewButtonColumnDeleteSelectedType.Name = "dataGridViewButtonColumnDeleteSelectedType";
            this.dataGridViewButtonColumnDeleteSelectedType.ReadOnly = true;
            this.dataGridViewButtonColumnDeleteSelectedType.Text = "Delete";
            this.dataGridViewButtonColumnDeleteSelectedType.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumnDeleteSelectedType.Width = 44;
            // 
            // groupBoxSelectedSuppliers
            // 
            this.groupBoxSelectedSuppliers.Controls.Add(this.dataGridViewSelectedSuppliers);
            this.groupBoxSelectedSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSelectedSuppliers.Location = new System.Drawing.Point(456, 3);
            this.groupBoxSelectedSuppliers.Name = "groupBoxSelectedSuppliers";
            this.groupBoxSelectedSuppliers.Size = new System.Drawing.Size(448, 150);
            this.groupBoxSelectedSuppliers.TabIndex = 0;
            this.groupBoxSelectedSuppliers.TabStop = false;
            this.groupBoxSelectedSuppliers.Text = "Selected Suppliers";
            // 
            // dataGridViewSelectedSuppliers
            // 
            this.dataGridViewSelectedSuppliers.AllowUserToAddRows = false;
            this.dataGridViewSelectedSuppliers.AllowUserToDeleteRows = false;
            this.dataGridViewSelectedSuppliers.AllowUserToOrderColumns = true;
            this.dataGridViewSelectedSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewColumnSelectedSupplierId,
            this.dataGridViewColumnSelectedSupplierName,
            this.dataGridViewColumnSelectedSupplierAddress,
            this.dataGridViewButtonColumnDeleteSelectedSupplier});
            this.dataGridViewSelectedSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelectedSuppliers.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewSelectedSuppliers.Name = "dataGridViewSelectedSuppliers";
            this.dataGridViewSelectedSuppliers.ReadOnly = true;
            this.dataGridViewSelectedSuppliers.Size = new System.Drawing.Size(442, 131);
            this.dataGridViewSelectedSuppliers.TabIndex = 0;
            this.dataGridViewSelectedSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSelectedSuppliers_CellContentClick);
            // 
            // dataGridViewColumnSelectedSupplierId
            // 
            this.dataGridViewColumnSelectedSupplierId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewColumnSelectedSupplierId.HeaderText = "Id";
            this.dataGridViewColumnSelectedSupplierId.Name = "dataGridViewColumnSelectedSupplierId";
            this.dataGridViewColumnSelectedSupplierId.ReadOnly = true;
            this.dataGridViewColumnSelectedSupplierId.Width = 41;
            // 
            // dataGridViewColumnSelectedSupplierName
            // 
            this.dataGridViewColumnSelectedSupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnSelectedSupplierName.HeaderText = "Name";
            this.dataGridViewColumnSelectedSupplierName.Name = "dataGridViewColumnSelectedSupplierName";
            this.dataGridViewColumnSelectedSupplierName.ReadOnly = true;
            // 
            // dataGridViewColumnSelectedSupplierAddress
            // 
            this.dataGridViewColumnSelectedSupplierAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewColumnSelectedSupplierAddress.HeaderText = "Address";
            this.dataGridViewColumnSelectedSupplierAddress.Name = "dataGridViewColumnSelectedSupplierAddress";
            this.dataGridViewColumnSelectedSupplierAddress.ReadOnly = true;
            this.dataGridViewColumnSelectedSupplierAddress.Width = 70;
            // 
            // dataGridViewButtonColumnDeleteSelectedSupplier
            // 
            this.dataGridViewButtonColumnDeleteSelectedSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewButtonColumnDeleteSelectedSupplier.HeaderText = "Delete";
            this.dataGridViewButtonColumnDeleteSelectedSupplier.Name = "dataGridViewButtonColumnDeleteSelectedSupplier";
            this.dataGridViewButtonColumnDeleteSelectedSupplier.ReadOnly = true;
            this.dataGridViewButtonColumnDeleteSelectedSupplier.Text = "Delete";
            this.dataGridViewButtonColumnDeleteSelectedSupplier.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumnDeleteSelectedSupplier.Width = 44;
            // 
            // tableLayoutPanelProductsDetail
            // 
            this.tableLayoutPanelProductsDetail.ColumnCount = 4;
            this.tableLayoutPanelProductsDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelProductsDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProductsDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelProductsDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProductsDetail.Controls.Add(label1, 2, 1);
            this.tableLayoutPanelProductsDetail.Controls.Add(this.tableLayoutPanel1, 3, 1);
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
            this.tableLayoutPanelProductsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelProductsDetail.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelProductsDetail.Name = "tableLayoutPanelProductsDetail";
            this.tableLayoutPanelProductsDetail.RowCount = 5;
            this.tableLayoutPanelProductsDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanelProductsDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.66667F));
            this.tableLayoutPanelProductsDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanelProductsDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanelProductsDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelProductsDetail.Size = new System.Drawing.Size(907, 182);
            this.tableLayoutPanelProductsDetail.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.isActiveCheckBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(isActiveLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUnit, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(546, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 25);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.Checked = true;
            this.isActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isActiveCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isActiveCheckBox.Location = new System.Drawing.Point(241, 3);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(114, 19);
            this.isActiveCheckBox.TabIndex = 28;
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtUnit
            // 
            this.txtUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUnit.Location = new System.Drawing.Point(3, 3);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(117, 20);
            this.txtUnit.TabIndex = 29;
            // 
            // txtDetail
            // 
            this.txtDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetail.Location = new System.Drawing.Point(93, 59);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetail.Size = new System.Drawing.Size(357, 63);
            this.txtDetail.TabIndex = 26;
            // 
            // numQuantity
            // 
            this.numQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numQuantity.Location = new System.Drawing.Point(93, 28);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(357, 20);
            this.numQuantity.TabIndex = 25;
            // 
            // txtProductName
            // 
            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductName.Location = new System.Drawing.Point(93, 3);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(357, 20);
            this.txtProductName.TabIndex = 24;
            // 
            // comboBoxProductBrand_Add
            // 
            this.comboBoxProductBrand_Add.DataSource = this.productBrandBindingSource_All;
            this.comboBoxProductBrand_Add.DisplayMember = "Name";
            this.comboBoxProductBrand_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxProductBrand_Add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductBrand_Add.FormattingEnabled = true;
            this.comboBoxProductBrand_Add.Location = new System.Drawing.Point(546, 59);
            this.comboBoxProductBrand_Add.Name = "comboBoxProductBrand_Add";
            this.comboBoxProductBrand_Add.Size = new System.Drawing.Size(358, 21);
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
            this.comboBoxProductTypes_Add.Location = new System.Drawing.Point(93, 128);
            this.comboBoxProductTypes_Add.Name = "comboBoxProductTypes_Add";
            this.comboBoxProductTypes_Add.Size = new System.Drawing.Size(357, 21);
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
            this.comboBoxSuppliers_Add.Location = new System.Drawing.Point(546, 128);
            this.comboBoxSuppliers_Add.Name = "comboBoxSuppliers_Add";
            this.comboBoxSuppliers_Add.Size = new System.Drawing.Size(358, 21);
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
            this.btnAddProductType.Location = new System.Drawing.Point(375, 153);
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
            this.btnAddSupplier.Location = new System.Drawing.Point(829, 153);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(75, 26);
            this.btnAddSupplier.TabIndex = 29;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // numPrice
            // 
            this.numPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPrice.Location = new System.Drawing.Point(546, 3);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(358, 20);
            this.numPrice.TabIndex = 30;
            // 
            // btnAddAndClose
            // 
            this.btnAddAndClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddAndClose.Location = new System.Drawing.Point(229, 3);
            this.btnAddAndClose.Name = "btnAddAndClose";
            this.btnAddAndClose.Size = new System.Drawing.Size(220, 26);
            this.btnAddAndClose.TabIndex = 1;
            this.btnAddAndClose.Text = "Add And Close Window";
            this.btnAddAndClose.UseVisualStyleBackColor = true;
            this.btnAddAndClose.Click += new System.EventHandler(this.btnAddAndClose_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(913, 417);
            this.Controls.Add(this.groupBoxActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddProductForm";
            this.Text = "Product Forms";
            this.groupBoxActions.ResumeLayout(false);
            this.tableLayoutPanelActionButtons.ResumeLayout(false);
            this.tableLayoutPanelAddTypesAndSupplier.ResumeLayout(false);
            this.groupBoxSelectedTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedTypes)).EndInit();
            this.groupBoxSelectedSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedSuppliers)).EndInit();
            this.tableLayoutPanelProductsDetail.ResumeLayout(false);
            this.tableLayoutPanelProductsDetail.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandBindingSource_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelActionButtons;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddTypesAndSupplier;
        private System.Windows.Forms.GroupBox groupBoxSelectedTypes;
        private System.Windows.Forms.DataGridView dataGridViewSelectedTypes;
        private System.Windows.Forms.GroupBox groupBoxSelectedSuppliers;
        private System.Windows.Forms.DataGridView dataGridViewSelectedSuppliers;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumnSelectedTypesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumnSelectedTypesName;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumnDeleteSelectedType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumnSelectedSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumnSelectedSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewColumnSelectedSupplierAddress;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumnDeleteSelectedSupplier;
        private System.Windows.Forms.Button btnAddAndClose;
    }
}