using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi_Version2.Models.DTOs;
using QuanLySieuThi_Version2.Models;
using System.Data.Entity;
using System.ComponentModel;

namespace QuanLySieuThi_Version2.BUS
{
    class ProductsSuppliersBUS
    {
        ApplicationDbContext db;
        public ProductsSuppliersBUS()
        {
            db = new ApplicationDbContext();
            db.Suppliers.Load();
            db.Products.Load();
        }

        public BindingList<SuppliersProducts> GetAllSupplierProduct()
        {
            try
            {
                BindingList<SuppliersProducts> suppliersProducts = new BindingList<SuppliersProducts>();
                foreach (var supplier in db.Suppliers.Include(p => p.Products).ToList())
                {
                    foreach (var product in supplier.Products)
                    {
                        suppliersProducts.Add(new SuppliersProducts()
                        {
                            SupplierId = supplier.Id,
                            ProductId = product.Id,
                            SupplierName = supplier.Name,
                            ProductName = product.Name
                        });
                    }
                }
                return suppliersProducts;
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected errors have occcured, " +
                                 "please contact your administrator\n" + ex.Message);
            }
        }
    }
}
