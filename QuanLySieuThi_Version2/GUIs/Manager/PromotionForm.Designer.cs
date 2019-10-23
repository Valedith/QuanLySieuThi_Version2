namespace QuanLySieuThi_Version2.GUIs.Manager
{
    partial class PromotionForm
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
            this.splitContainerMaster = new System.Windows.Forms.SplitContainer();
            this.splitContainerRightPanel = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeftPanel = new System.Windows.Forms.SplitContainer();
            this.promotionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promotionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMaster)).BeginInit();
            this.splitContainerMaster.Panel1.SuspendLayout();
            this.splitContainerMaster.Panel2.SuspendLayout();
            this.splitContainerMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRightPanel)).BeginInit();
            this.splitContainerRightPanel.Panel1.SuspendLayout();
            this.splitContainerRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftPanel)).BeginInit();
            this.splitContainerLeftPanel.Panel1.SuspendLayout();
            this.splitContainerLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promotionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMaster
            // 
            this.splitContainerMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMaster.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMaster.Name = "splitContainerMaster";
            // 
            // splitContainerMaster.Panel1
            // 
            this.splitContainerMaster.Panel1.Controls.Add(this.splitContainerLeftPanel);
            // 
            // splitContainerMaster.Panel2
            // 
            this.splitContainerMaster.Panel2.Controls.Add(this.splitContainerRightPanel);
            this.splitContainerMaster.Size = new System.Drawing.Size(935, 450);
            this.splitContainerMaster.SplitterDistance = 461;
            this.splitContainerMaster.TabIndex = 0;
            // 
            // splitContainerRightPanel
            // 
            this.splitContainerRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRightPanel.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRightPanel.Name = "splitContainerRightPanel";
            this.splitContainerRightPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRightPanel.Panel1
            // 
            this.splitContainerRightPanel.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerRightPanel.Size = new System.Drawing.Size(470, 450);
            this.splitContainerRightPanel.SplitterDistance = 210;
            this.splitContainerRightPanel.TabIndex = 0;
            // 
            // splitContainerLeftPanel
            // 
            this.splitContainerLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeftPanel.Name = "splitContainerLeftPanel";
            this.splitContainerLeftPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeftPanel.Panel1
            // 
            this.splitContainerLeftPanel.Panel1.AutoScroll = true;
            this.splitContainerLeftPanel.Panel1.Controls.Add(this.promotionDataGridView);
            this.splitContainerLeftPanel.Size = new System.Drawing.Size(461, 450);
            this.splitContainerLeftPanel.SplitterDistance = 210;
            this.splitContainerLeftPanel.TabIndex = 0;
            // 
            // promotionBindingSource
            // 
            this.promotionBindingSource.DataSource = typeof(QuanLySieuThi_Version2.Models.Promotion);
            // 
            // promotionDataGridView
            // 
            this.promotionDataGridView.AutoGenerateColumns = false;
            this.promotionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.promotionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.promotionDataGridView.DataSource = this.promotionBindingSource;
            this.promotionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promotionDataGridView.Location = new System.Drawing.Point(0, 0);
            this.promotionDataGridView.Name = "promotionDataGridView";
            this.promotionDataGridView.Size = new System.Drawing.Size(461, 210);
            this.promotionDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiscountRate";
            this.dataGridViewTextBoxColumn3.HeaderText = "DiscountRate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsActive";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // PromotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.splitContainerMaster);
            this.Name = "PromotionForm";
            this.Text = "PromotionForm";
            this.splitContainerMaster.Panel1.ResumeLayout(false);
            this.splitContainerMaster.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMaster)).EndInit();
            this.splitContainerMaster.ResumeLayout(false);
            this.splitContainerRightPanel.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRightPanel)).EndInit();
            this.splitContainerRightPanel.ResumeLayout(false);
            this.splitContainerLeftPanel.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftPanel)).EndInit();
            this.splitContainerLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.promotionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMaster;
        private System.Windows.Forms.SplitContainer splitContainerLeftPanel;
        private System.Windows.Forms.DataGridView promotionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource promotionBindingSource;
        private System.Windows.Forms.SplitContainer splitContainerRightPanel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}