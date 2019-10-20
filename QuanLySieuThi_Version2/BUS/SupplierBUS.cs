using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi_Version2.Infrastructures;
using QuanLySieuThi_Version2.Models;
using QuanLySieuThi_Version2.Models.DTOs;

namespace QuanLySieuThi_Version2.BUS
{
    class SupplierBUS
    {
        ApplicationDbContext db;
        public SupplierBUS()
        {
            db = new ApplicationDbContext();
            db.Suppliers.Load();
            db.Products.Load();
        }
        #region Supplier's methods
        public BindingList<Supplier> GetAllSuppliersBindingList()
        {
            try
            {
                return db.Suppliers.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        public CustomResult AddSupplier(Supplier supplier)
        {
            try
            {
                if (db.Suppliers.FirstOrDefault(s => s.Name == supplier.Name
                                      && s.PhoneNumber == supplier.PhoneNumber
                                      && s.Address == supplier.Address) != null)
                {
                    return new CustomResult(CustomResultType.Existed, "This Supplier exists");
                }
                if (!Validator.IsPhoneNumber(supplier.PhoneNumber))
                {
                    return new CustomResult(CustomResultType.InvalidInput, CustomInvalidInputType.PhoneNumber, "Invalid Phone number");
                }
                if (!ModelState.IsValid(supplier))
                {
                    return new CustomResult(CustomResultType.InvalidModelState);
                }
                db.Suppliers.Add(supplier);
                db.SaveChanges();
                return new CustomResult(CustomResultType.Succeed);
            }
            catch (Exception ex)
            {
                return new CustomResult(CustomResultType.UnexpectedError,
                    "Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        public CustomResult EditSupplier(Supplier supplier)
        {
            try
            {
                if (db.Suppliers.Find(supplier.Id) == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "Couldn't find this supplier to edit");
                }
                if (db.Suppliers.FirstOrDefault(s => s.Name == supplier.Name
                                      && s.PhoneNumber == supplier.PhoneNumber
                                      && s.Address == supplier.Address
                                      && s.Id != supplier.Id) != null)
                {
                    return new CustomResult(CustomResultType.Existed, "This Supplier exists");
                }
                if (!Validator.IsPhoneNumber(supplier.PhoneNumber))
                {
                    return new CustomResult(CustomResultType.InvalidInput, CustomInvalidInputType.PhoneNumber, "Invalid Phone number");
                }
                if (!ModelState.IsValid(supplier))
                {
                    return new CustomResult(CustomResultType.InvalidModelState);
                }
                db.Set<Supplier>().AddOrUpdate(supplier);
                db.SaveChanges();
                return new CustomResult(CustomResultType.Succeed);
            }
            catch (Exception ex)
            {
                return new CustomResult(CustomResultType.UnexpectedError,
                    "Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        public CustomResult ChangeLockSupplier(int id)
        {
            try
            {
                Supplier supplier = db.Suppliers.Find(id);
                if (supplier == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "Couldn't find this Supplier to Lock/Unlock");
                }
                if (ModelState.IsValid(supplier))
                {
                    supplier.IsActive = !supplier.IsActive;
                    db.Set<Supplier>().AddOrUpdate(supplier);
                    db.SaveChanges();
                    return new CustomResult(CustomResultType.Succeed);
                }
                else
                {
                    return new CustomResult(CustomResultType.InvalidModelState);
                }
            }
            catch (Exception ex)
            {
                return new CustomResult(CustomResultType.UnexpectedError,
                    "Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        public Supplier SearchSupplierByID(int id)
        {
            try
            {
                return db.Suppliers.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        public List<Supplier> SearchSupplierByName(string name)
        {
            try
            {
                return db.Suppliers.Where(s => s.Name.ToLower().Contains(name.ToLower())).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        #endregion

        #region Suppliers-Products
        public BindingList<Supplier> GetAllSuppliersWithNamePlusId()
        {
            try
            {
                BindingList<Supplier> suppliers = new BindingList<Supplier>();
                foreach (var supplier in db.Suppliers.Local.Where(s => s.IsActive == true))
                {
                    suppliers.Add(new Supplier()
                    {
                        Id = supplier.Id,
                        Name = supplier.Name + " (ID: " + supplier.Id + ")"
                    });
                }
                return suppliers;
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        public BindingList<Product> GetAllProductssWithNamePlusId()
        {
            try
            {
                BindingList<Product> products = new BindingList<Product>();
                foreach (var product in db.Products.Local.OrderBy(p => p.Name).Where(p => p.IsActive == true))
                {
                    products.Add(new Product()
                    {
                        Id = product.Id,
                        Name = product.Name + " (ID: " + product.Id + ")"
                    });
                }
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        public BindingList<SuppliersProducts> GetAllSuppliersProductsBindingList()
        {
            try
            {
                BindingList<SuppliersProducts> suppliersProducts = new BindingList<SuppliersProducts>();
                foreach (var supplier in db.Suppliers.Include(s => s.Products).Where(s => s.IsActive == true))
                {
                    foreach (var product in supplier.Products.Where(p=>p.IsActive == true))
                    {

                        suppliersProducts.Add(new SuppliersProducts()
                        {
                            SupplierId = supplier.Id,
                            ProductId = product.Id,
                            SupplierName = supplier.Name + " (ID: " + supplier.Id + ")",
                            ProductName = product.Name + " (ID: " + product.Id + ")"
                        });
                    }
                }
                return suppliersProducts;
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }

        public CustomResult AddSupplierProduct(int supplierID, int productID)
        {
            try
            {
                Supplier supplier = db.Suppliers.Include(s => s.Products)
                    .FirstOrDefault(s => s.Id == supplierID);
                Product product = db.Products.Include(p => p.Suppliers).FirstOrDefault(p => p.Id == productID);
                if (supplier == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "Couldn't find this supplier");
                }
                if (product == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "Couldn't find this product");
                }
                if(!supplier.IsActive)
                {
                    return new CustomResult(CustomResultType.NotExisted, "This Supplier is being locked");
                }
                if (!product.IsActive)
                {
                    return new CustomResult(CustomResultType.NotExisted, "This Product is being locked");
                }
                if (supplier.Products.FirstOrDefault(p => p.Id == productID) != null)
                {
                    return new CustomResult(CustomResultType.Existed, "This Product has already been supplied by this supplier");
                }
                supplier.Products.Add(product);
                product.Suppliers.Add(supplier);
                db.Set<Supplier>().AddOrUpdate(supplier);
                db.Set<Product>().AddOrUpdate(product);
                db.SaveChanges();
                return new CustomResult(CustomResultType.Succeed);
            }
            catch (Exception ex)
            {
                return new CustomResult(CustomResultType.UnexpectedError,
                    "Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        #endregion
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
