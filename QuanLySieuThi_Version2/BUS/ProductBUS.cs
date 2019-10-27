using QuanLySieuThi_Version2.Infrastructures;
using QuanLySieuThi_Version2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi_Version2.BUS
{
    class ProductBUS : BaseBUS
    {
        public ProductBUS() : base()
        {
            db.Products
                     .Include(p => p.ProductTypes)
                     .Include(p => p.ProductBrand)
                     .Include(p => p.Suppliers).Load();
        }

        public void ReloadContext()
        {
            Dispose();
            db = new ApplicationDbContext();
            db.Products
                     .Include(p => p.ProductTypes)
                     .Include(p => p.ProductBrand)
                     .Include(p => p.Suppliers).Load();
        }
        public void RollBack()
        {

            var changedEntries = db.ChangeTracker.Entries()
                .Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in changedEntries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
        }


        public List<ProductBrand> GetProductBrands()
        {
            try
            {
                return db.ProductBrands.Where(pb => pb.IsActive == true).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured.\n" + ex.Message);
            }
        }
        public List<ProductType> GetProductTypes()
        {
            try
            {
                return db.ProductTypes.Where(pt => pt.IsActive == true).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured.\n" + ex.Message);
            }
        }
        public List<Supplier> GetSuppliers()
        {
            try
            {
                return db.Suppliers.Where(s => s.IsActive == true).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured.\n" + ex.Message);
            }
        }
        //GetLocked: Get all product despite its Types or Brand are locked
        public BindingList<Product> GetAllProducts(bool getLocked = false)
        {
            try
            {
                var filteredProducts = db.Products.Local;
                if (getLocked)
                {
                    return filteredProducts.ToBindingList();
                }
                else
                {
                    return new SortableBindingList<Product>(filteredProducts
                        .Where(p => p.ProductBrand.IsActive == true
                                && p.ProductTypes.All(pt => pt.IsActive)));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured.\n" + ex.Message);
            }
        }

        public CustomResult AddProduct(Product product)
        {
            try
            {
                if (!ModelState.IsValid(product))
                {
                    return new CustomResult(CustomResultType.InvalidModelState);
                }
                db.Products.Add(product);
                db.SaveChanges();
                return new CustomResult(CustomResultType.Succeed);
            }
            catch (Exception ex)
            {
                return new CustomResult(CustomResultType.UnexpectedError, "Some unexpected error has occured.\n" + ex.Message);
            }
        }

        public CustomResult EditProducts(Product product)
        {
            db.SaveChanges();
            return new CustomResult(CustomResultType.Succeed);
        }
    }
}
