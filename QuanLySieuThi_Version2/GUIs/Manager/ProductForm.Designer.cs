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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode5 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode6 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode7 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode8 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode9 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode10 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode11 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode12 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode13 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode14 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode15 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode16 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode17 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode18 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode19 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode20 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode21 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode22 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode23 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode24 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode25 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode26 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode27 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode28 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode29 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode30 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode31 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.productGridControl = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierProducts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductBrandId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.productGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // productGridControl
            // 
            this.productGridControl.DataSource = this.productsBindingSource;
            this.productGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "ProductTypes";
            gridLevelNode9.RelationName = "Products";
            gridLevelNode8.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode9});
            gridLevelNode8.RelationName = "ProductTypes";
            gridLevelNode11.RelationName = "Products";
            gridLevelNode10.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode11});
            gridLevelNode10.RelationName = "Promotions";
            gridLevelNode7.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode8,
            gridLevelNode10});
            gridLevelNode7.RelationName = "Products";
            gridLevelNode6.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode7});
            gridLevelNode6.RelationName = "ProductTypes";
            gridLevelNode15.RelationName = "Products";
            gridLevelNode14.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode15});
            gridLevelNode14.RelationName = "ProductTypes";
            gridLevelNode17.RelationName = "Products";
            gridLevelNode16.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode17});
            gridLevelNode16.RelationName = "Promotions";
            gridLevelNode13.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode14,
            gridLevelNode16});
            gridLevelNode13.RelationName = "Products";
            gridLevelNode12.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode13});
            gridLevelNode12.RelationName = "Promotions";
            gridLevelNode5.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode6,
            gridLevelNode12});
            gridLevelNode5.RelationName = "Products";
            gridLevelNode4.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode5});
            gridLevelNode4.RelationName = "ProductTypes";
            gridLevelNode23.RelationName = "Products";
            gridLevelNode22.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode23});
            gridLevelNode22.RelationName = "ProductTypes";
            gridLevelNode25.RelationName = "Products";
            gridLevelNode24.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode25});
            gridLevelNode24.RelationName = "Promotions";
            gridLevelNode21.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode22,
            gridLevelNode24});
            gridLevelNode21.RelationName = "Products";
            gridLevelNode20.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode21});
            gridLevelNode20.RelationName = "ProductTypes";
            gridLevelNode29.RelationName = "Products";
            gridLevelNode28.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode29});
            gridLevelNode28.RelationName = "ProductTypes";
            gridLevelNode31.RelationName = "Products";
            gridLevelNode30.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode31});
            gridLevelNode30.RelationName = "Promotions";
            gridLevelNode27.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode28,
            gridLevelNode30});
            gridLevelNode27.RelationName = "Products";
            gridLevelNode26.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode27});
            gridLevelNode26.RelationName = "Promotions";
            gridLevelNode19.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode20,
            gridLevelNode26});
            gridLevelNode19.RelationName = "Products";
            gridLevelNode18.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode19});
            gridLevelNode18.RelationName = "Promotions";
            gridLevelNode3.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode4,
            gridLevelNode18});
            gridLevelNode3.RelationName = "Products";
            gridLevelNode2.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            gridLevelNode2.RelationName = "Promotions";
            this.productGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.productGridControl.Location = new System.Drawing.Point(2, 39);
            this.productGridControl.MainView = this.gridView1;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.Size = new System.Drawing.Size(903, 474);
            this.productGridControl.TabIndex = 0;
            this.productGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3});
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(QuanLySieuThi_Version2.Models.Product);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colQuantity,
            this.colPrice,
            this.colDetail,
            this.colIsActive,
            this.colSupplierProducts,
            this.colProductBrandId,
            this.colProductBrand});
            this.gridView1.GridControl = this.productGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // colDetail
            // 
            this.colDetail.FieldName = "Detail";
            this.colDetail.Name = "colDetail";
            this.colDetail.Visible = true;
            this.colDetail.VisibleIndex = 4;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 5;
            // 
            // colSupplierProducts
            // 
            this.colSupplierProducts.FieldName = "SupplierProducts";
            this.colSupplierProducts.Name = "colSupplierProducts";
            this.colSupplierProducts.Visible = true;
            this.colSupplierProducts.VisibleIndex = 8;
            // 
            // colProductBrandId
            // 
            this.colProductBrandId.FieldName = "ProductBrandId";
            this.colProductBrandId.Name = "colProductBrandId";
            this.colProductBrandId.Visible = true;
            this.colProductBrandId.VisibleIndex = 6;
            // 
            // colProductBrand
            // 
            this.colProductBrand.FieldName = "ProductBrand";
            this.colProductBrand.Name = "colProductBrand";
            this.colProductBrand.Visible = true;
            this.colProductBrand.VisibleIndex = 7;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.productGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(907, 515);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Products";
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 449);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(907, 66);
            this.windowsUIButtonPanel1.TabIndex = 4;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 515);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Controls.Add(this.groupControl1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraGrid.GridControl productGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colProductBrandId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductBrand;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}