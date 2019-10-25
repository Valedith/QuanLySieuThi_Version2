using QuanLySieuThi_Version2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi_Version2.BUS
{
    class ProductBUS :BaseBUS
    {
        public ProductBUS():base()
        {
            db.Products.Include(p=>p.ProductBrand).Load();

        }
        public BindingList<Product> GetAllProducts()
        {
            try
            {
                return db.Products.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured.\n" + ex.Message);
            }
        }
    }
}
