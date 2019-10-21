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
            db.SupplierProducts.Load();
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
        public BindingList<Product> GetAllProductsWithNamePlusId()
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
        public List<SupplierProductDTO> GetAllSupplierProductDTOWithNamePlusId()
        {
            try
            {
                List<SupplierProductDTO> suppliersProducts = new List<SupplierProductDTO>();
                foreach (var supplierProduct in db.SupplierProducts
                            .Where(sp => sp.Supplier.IsActive == true&& sp.Product.IsActive == true).ToList())
                {
                    if(suppliersProducts.FirstOrDefault(sp => sp.SupplierId == supplierProduct.SupplierId) == null)
                    {
                        suppliersProducts.Add(new SupplierProductDTO()
                        {
                            ProductId = supplierProduct.Product.Id,
                            SupplierId = supplierProduct.Supplier.Id,
                            SupplierName = supplierProduct.Supplier.Name + " (ID: " + supplierProduct.Supplier.Id + ")",
                            ProductName = supplierProduct.Product.Name + " (ID: " + supplierProduct.Product.Id + ")"
                        });
                    }
                }
                return suppliersProducts;
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
            throw new NotImplementedException();
        }
        public BindingList<SupplierProductDTO> GetAllSupplierProductDTOBindingList()
        {
            try
            {
                BindingList<SupplierProductDTO> suppliersProducts = new BindingList<SupplierProductDTO>();
                foreach (var supplierProduct in db.SupplierProducts.Where(sp => sp.Supplier.IsActive == true))
                {
                    suppliersProducts.Add(new SupplierProductDTO()
                    {
                        ProductId = supplierProduct.Product.Id,
                        SupplierId = supplierProduct.Supplier.Id,
                        SupplierName = supplierProduct.Supplier.Name,
                        ProductName = supplierProduct.Product.Name,
                        IsSupplying = supplierProduct.IsSupplying
                    });
                }
                return suppliersProducts;
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        public List<SupplierProductDTO> GetProductsBySupplierWithNamePlusId(int supplierId)
        {
            try
            {
                List<SupplierProductDTO> supplierProductDTOs = new List<SupplierProductDTO>();
                foreach(var supplierProduct in db.Suppliers.Find(supplierId).SupplierProducts.Where(sp => sp.Product.IsActive == true).ToList())
                {
                    supplierProductDTOs.Add(new SupplierProductDTO() {
                        ProductId = supplierProduct.ProductId,
                        SupplierId = supplierProduct.SupplierId,
                        ProductName = supplierProduct.Product.Name+" (ID: "+supplierProduct.ProductId+")",
                        SupplierName = supplierProduct.Supplier.Name + " (ID: " + supplierProduct.SupplierId + ")"
                    });
                }
                return supplierProductDTOs;
            }
            catch(Exception ex)
            {
                throw new Exception("Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }

        public List<SupplierProductDTO> FindSupplierBySupplierID(int supplierId)
        {
            try
            {
                List<SupplierProductDTO> supplierProductDTOs = new List<SupplierProductDTO>();
                Supplier supplier = db.Suppliers.Find(supplierId);
                if(supplier != null)
                {
                    foreach (var supplierProduct in supplier.SupplierProducts.Where(sp => sp.Product.IsActive == true))
                    {
                        supplierProductDTOs.Add(new SupplierProductDTO()
                        {
                            ProductId = supplierProduct.ProductId,
                            SupplierId = supplierProduct.SupplierId,
                            ProductName = supplierProduct.Product.Name,
                            SupplierName = supplierProduct.Supplier.Name,
                            IsSupplying = supplierProduct.IsSupplying
                        });
                    }
                }
                
                return supplierProductDTOs;
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        public List<SupplierProductDTO> FindSupplierBySupplierName(string supplierName)
        {
            try
            {
                List<SupplierProductDTO> supplierProductDTOs = new List<SupplierProductDTO>();
                List<Supplier> suppliers = db.Suppliers.Include(s => s.SupplierProducts)
                    .Where(s => s.Name.Contains(supplierName) && s.IsActive == true).ToList();
                if (suppliers.Count >0)
                {
                    foreach (var supplier in suppliers)
                    {
                        foreach (var supplierProduct in supplier.SupplierProducts.Where(sp => sp.Product.IsActive == true).ToList())
                        {
                            supplierProductDTOs.Add(new SupplierProductDTO()
                            {
                                ProductId = supplierProduct.ProductId,
                                SupplierId = supplierProduct.SupplierId,
                                ProductName = supplierProduct.Product.Name,
                                SupplierName = supplierProduct.Supplier.Name,
                                IsSupplying = supplierProduct.IsSupplying
                            });
                        }
                    }
                }

                return supplierProductDTOs;
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        public List<SupplierProductDTO> FindSupplierByProductId(int productId)
        {
            try
            {
                List<SupplierProductDTO> supplierProductDTOs = new List<SupplierProductDTO>();
                Product product = db.Products.Find(productId);
                if (product != null)
                {
                    foreach (var supplierProduct in product.SupplierProducts.Where(sp => sp.Supplier.IsActive == true))
                    {
                        supplierProductDTOs.Add(new SupplierProductDTO()
                        {
                            ProductId = supplierProduct.ProductId,
                            SupplierId = supplierProduct.SupplierId,
                            ProductName = supplierProduct.Product.Name,
                            SupplierName = supplierProduct.Supplier.Name,
                            IsSupplying = supplierProduct.IsSupplying
                        });
                    }
                }

                return supplierProductDTOs;
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        public List<SupplierProductDTO> FindSupplierByProductName(string productName)
        {
            try
            {
                List<SupplierProductDTO> supplierProductDTOs = new List<SupplierProductDTO>();
                List<Product> products = db.Products.Include(s => s.SupplierProducts)
                    .Where(s => s.Name.Contains(productName) && s.IsActive ==true).ToList();
                if (products.Count > 0)
                {
                    foreach (var product in products)
                    {
                        foreach (var supplierProduct in product.SupplierProducts.Where(sp => sp.Supplier.IsActive == true).ToList())
                        {
                            supplierProductDTOs.Add(new SupplierProductDTO()
                            {
                                ProductId = supplierProduct.ProductId,
                                SupplierId = supplierProduct.SupplierId,
                                ProductName = supplierProduct.Product.Name,
                                SupplierName = supplierProduct.Supplier.Name,
                                IsSupplying = supplierProduct.IsSupplying
                            });
                        }
                    }
                }

                return supplierProductDTOs;
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
                Supplier supplier = db.Suppliers.FirstOrDefault(s => s.Id == supplierID);
                Product product = db.Products.FirstOrDefault(p => p.Id == productID);
                if (supplier == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "Couldn't find this supplier");
                }
                if (product == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "Couldn't find this product");
                }
                if (!supplier.IsActive)
                {
                    return new CustomResult(CustomResultType.NotExisted, "This Supplier is being locked");
                }
                if (!product.IsActive)
                {
                    return new CustomResult(CustomResultType.NotExisted, "This Product is being locked");
                }
                if (db.SupplierProducts.FirstOrDefault(sp => sp.ProductId == productID && sp.SupplierId == supplier.Id) != null)
                {
                    return new CustomResult(CustomResultType.Existed, "This Product has already been supplied by this supplier");
                }
                SupplierProduct supplierProduct = new SupplierProduct()
                {
                    Supplier = supplier,
                    Product = product,
                    IsSupplying = true
                };

                db.SupplierProducts.Add(supplierProduct);
                db.SaveChanges();
                return new CustomResult(CustomResultType.Succeed);
            }
            catch (Exception ex)
            {
                return new CustomResult(CustomResultType.UnexpectedError,
                    "Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }

        }
        public CustomResult ChangeSupplyingStatusSupplierProduct(int supplierProduct, int productId)
        {
            try
            {
                SupplierProduct foundSupplierProduct = db.SupplierProducts
                                                        .FirstOrDefault(sp => sp.ProductId == productId
                                                          && sp.SupplierId == supplierProduct);
                if (foundSupplierProduct == null)
                {
                    return new CustomResult(CustomResultType.NotExisted,
                    "Couldn't find this entry, please try again!!");
                }
                foundSupplierProduct.IsSupplying = !foundSupplierProduct.IsSupplying;
                db.Set<SupplierProduct>().AddOrUpdate(foundSupplierProduct);
                db.SaveChanges();
                return new CustomResult(CustomResultType.Succeed);
            }
            catch (Exception ex)
            {
                return new CustomResult(CustomResultType.UnexpectedError,
                    "Some unexpected error has occured, please contact your administrator.\n" + ex.Message);
            }
        }
        public CustomResult RemoveSupplierProduct(int supplierProduct, int productId)
        {
            try
            {
                SupplierProduct foundSupplierProduct = db.SupplierProducts
                                                        .FirstOrDefault(sp => sp.ProductId == productId
                                                          && sp.SupplierId == supplierProduct);
                if (foundSupplierProduct == null)
                {
                    return new CustomResult(CustomResultType.NotExisted,
                    "Couldn't find this entry, please try again!!");
                }
                db.Set<SupplierProduct>().Remove(foundSupplierProduct);
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
