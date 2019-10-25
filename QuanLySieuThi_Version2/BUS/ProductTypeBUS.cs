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
    class ProductTypeBUS : BaseBUS
    {

        public ProductTypeBUS() :base()
        {
            db.ProductTypes.Include(p => p.Products).Load();
            db.Products.Include(p=>p.ProductTypes).Load();
        }

        public BindingList<ProductType> GetAllProductTypes()
        {
            try
            {
                return db.ProductTypes.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occurred, please contact your administrator.\n" + ex.Message);
            }
        }
        public CustomResult AddProductType(ProductType productType)
        {
            try
            {
                if(db.ProductTypes.FirstOrDefault(pt=>pt.Name == productType.Name) != null)
                {
                    return new CustomResult(CustomResultType.Existed, "This Product type has already existed");
                }
                if(!ModelState.IsValid(productType))
                {
                    return new CustomResult(CustomResultType.InvalidModelState);
                }
                db.ProductTypes.Add(productType);
                db.SaveChanges();
                return new CustomResult(CustomResultType.Succeed);
            }
            catch (Exception ex)
            {
                return new CustomResult(CustomResultType.UnexpectedError, "Some unexpected error has occured\n" + ex.Message);
            }
        }
        public CustomResult EditProductType(ProductType productType)
        {
            try
            {
                if(db.ProductTypes.Find(productType.Id) == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "This Product Type does not exist");
                }
                if(db.ProductTypes.FirstOrDefault(pt=>pt.Name == productType.Name && pt.Id != productType.Id) != null)
                {
                    return new CustomResult(CustomResultType.Existed, "This Product Type has already existed");
                }
                if(!ModelState.IsValid(productType))
                {
                    return new CustomResult(CustomResultType.InvalidModelState);
                }
                db.Set<ProductType>().AddOrUpdate(productType);
                db.SaveChanges();
                return new CustomResult(CustomResultType.Succeed);
            }
            catch(Exception ex)
            {
                return new CustomResult(CustomResultType.UnexpectedError, "Some unexpected error has occured.\n" + ex.Message);
            }
        }
        public BindingList<ProductType> SearchProductTypeByID(int id)
        {
            try
            {
                return new BindingList<ProductType>(db.ProductTypes.Where(pt => pt.Id == id).ToList());
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured.\n"+ex.Message);
            }
        }
        public BindingList<ProductType> SearchProductTypeByName(string name)
        {
            try
            {
                return new BindingList<ProductType>(db.ProductTypes.Where(pt => pt.Name.Contains(name)).ToList());
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected error has occured.\n" + ex.Message);
            }
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
        public CustomResult AddProductTypeProduct(int productTypeId, int productId)
        {
            try
            {
                if (db.ProductTypes.FirstOrDefault(pt => pt.Id == productTypeId) == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "This Product Type does not exist");
                }
                if (db.Products.FirstOrDefault(p => p.Id == productId) == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "This Product does not exist");
                }
                ProductType productType = db.ProductTypes.Include(pt => pt.Products).FirstOrDefault(pt=>pt.Id == productTypeId);
                if(productType.Products.FirstOrDefault(p=>p.Id == productId) != null)
                {
                    return new CustomResult(CustomResultType.Existed, "This record exists");
                }
                productType.Products.Add(db.Products.Find(productId));
                db.Set<ProductType>().AddOrUpdate(productType);
                db.SaveChanges();
                return new CustomResult(CustomResultType.Succeed);
            }
            catch (Exception ex)
            {
                return new CustomResult(CustomResultType.UnexpectedError, "Some unexpected error has occured\n" + ex.Message);
            }
        }

        public CustomResult RemoveProductTypeProduct(int productTypeId, int productId)
        {
            try
            {
                if (db.ProductTypes.FirstOrDefault(pt => pt.Id == productTypeId) == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "This Product Type does not exist");
                }
                if (db.Products.FirstOrDefault(p => p.Id == productId) == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "This Product does not exist");
                }
                ProductType productType = db.ProductTypes.Include(pt => pt.Products).FirstOrDefault(pt => pt.Id == productTypeId);
                if (productType.Products.FirstOrDefault(p => p.Id == productId) == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "This record does not exists");
                }
                productType.Products.Remove(db.Products.Find(productId));
                db.Set<ProductType>().AddOrUpdate(productType);
                db.SaveChanges();
                return new CustomResult(CustomResultType.Succeed);
            }
            catch (Exception ex)
            {
                return new CustomResult(CustomResultType.UnexpectedError, "Some unexpected error has occured\n" + ex.Message);
            }
        }



        
    }
}
