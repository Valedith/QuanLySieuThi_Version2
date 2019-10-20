namespace QuanLySieuThi_Version2.GUIs.Manager
{
    partial class ProductBrandForm
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
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.productBrandDataGridView = new QuanLySieuThi_Version2.Infrastructures.CustomDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxSearchOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandBindingSource)).BeginInit();
            this.groupInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Location = new System.Drawing.Point(6, 106);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(51, 13);
            this.isActiveLabel.TabIndex = 3;
            this.isActiveLabel.Text = "Is Active:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(19, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name:";
            // 
            // productBrandDataGridView
            // 
            this.productBrandDataGridView.AllowUserToAddRows = false;
            this.productBrandDataGridView.AllowUserToDeleteRows = false;
            this.productBrandDataGridView.AllowUserToOrderColumns = true;
            this.productBrandDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productBrandDataGridView.AutoGenerateColumns = false;
            this.productBrandDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productBrandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productBrandDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.productBrandDataGridView.DataSource = this.productBrandBindingSource;
            this.productBrandDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productBrandDataGridView.Location = new System.Drawing.Point(340, 12);
            this.productBrandDataGridView.Name = "productBrandDataGridView";
            this.productBrandDataGridView.ReadOnly = true;
            this.productBrandDataGridView.Size = new System.Drawing.Size(487, 306);
            this.productBrandDataGridView.TabIndex = 7;
            this.productBrandDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productBrandDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsActive";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // productBrandBindingSource
            // 
            this.productBrandBindingSource.DataSource = typeof(QuanLySieuThi_Version2.Models.ProductBrand);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 29);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 61);
            this.txtName.TabIndex = 8;
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Location = new System.Drawing.Point(63, 106);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsActive.TabIndex = 9;
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.txtName);
            this.groupInfo.Controls.Add(this.checkBoxIsActive);
            this.groupInfo.Controls.Add(this.nameLabel);
            this.groupInfo.Controls.Add(this.isActiveLabel);
            this.groupInfo.Location = new System.Drawing.Point(12, 12);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(322, 191);
            this.groupInfo.TabIndex = 11;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Values";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnLock);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.comboBoxSearchOptions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchValue);
            this.groupBox1.Location = new System.Drawing.Point(12, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 110);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(254, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(155, 28);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(85, 23);
            this.btnLock.TabIndex = 5;
            this.btnLock.Text = "Lock/Unlock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(82, 28);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(257, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxSearchOptions
            // 
            this.comboBoxSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchOptions.FormattingEnabled = true;
            this.comboBoxSearchOptions.Location = new System.Drawing.Point(187, 72);
            this.comboBoxSearchOptions.Name = "comboBoxSearchOptions";
            this.comboBoxSearchOptions.Size = new System.Drawing.Size(64, 21);
            this.comboBoxSearchOptions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(50, 73);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(131, 20);
            this.txtSearchValue.TabIndex = 0;
            this.txtSearchValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchValue_KeyDown);
            // 
            // ProductBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 328);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.productBrandDataGridView);
            this.Name = "ProductBrandForm";
            this.Text = "Product Brand";
            ((System.ComponentModel.ISupportInitialize)(this.productBrandDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandBindingSource)).EndInit();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productBrandBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.Label nameLabel;
        private Infrastructures.CustomDataGridView productBrandDataGridView;
    }
}