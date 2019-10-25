using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace QuanLySieuThi_Version2.GUIs.Manager
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();

            // Instantiate a new DBContext
            QuanLySieuThi_Version2.Models.ApplicationDbContext dbContext = new QuanLySieuThi_Version2.Models.ApplicationDbContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.

            dbContext.Products.Include(p=>p.ProductTypes).LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    productsBindingSource.DataSource = dbContext.Products.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
