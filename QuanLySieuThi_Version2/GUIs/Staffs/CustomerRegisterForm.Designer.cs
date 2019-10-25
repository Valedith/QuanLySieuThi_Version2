namespace QuanLySieuThi_Version2.GUIs.Staffs
{
    partial class CustomerRegisterForm
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
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.customerGridControl = new DevExpress.XtraGrid.GridControl();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.customerGridControl);
            this.groupBoxCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCustomer.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(695, 237);
            this.groupBoxCustomer.TabIndex = 0;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customers";
            // 
            // customerGridControl
            // 
            this.customerGridControl.DataSource = this.customerBindingSource;
            this.customerGridControl.Location = new System.Drawing.Point(286, 19);
            this.customerGridControl.MainView = this.gridView1;
            this.customerGridControl.Name = "customerGridControl";
            this.customerGridControl.Size = new System.Drawing.Size(689, 218);
            this.customerGridControl.TabIndex = 0;
            this.customerGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(QuanLySieuThi_Version2.Models.Customer);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.customerGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxDetails.Location = new System.Drawing.Point(0, 237);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(291, 413);
            this.groupBoxDetails.TabIndex = 1;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // CustomerRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 650);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxCustomer);
            this.Name = "CustomerRegisterForm";
            this.Text = "CustomerRegister";
            this.groupBoxCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private DevExpress.XtraGrid.GridControl customerGridControl;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBoxDetails;
    }
}