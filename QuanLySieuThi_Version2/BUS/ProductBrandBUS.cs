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
    class ProductBrandBUS : BaseBUS
    {
        public ProductBrandBUS():base()
        {
            db.ProductBrands.Load();
        }

        public BindingList<ProductBrand> GetAllProductBrands()
        {
            try
            {

                // Call the Load method to get the data for the given DbSet
                // from the database.
                // The data is materialized as entities. The entities are managed by
                // the DbContext instance.
                return db.ProductBrands.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected errors have occcured, " +
                                 "please contact your administrator\n" + ex.Message);
            }
        }
        public CustomResult AddProductBrand(ProductBrand brand)
        {
            try
            {

                if (db.ProductBrands.FirstOrDefault(p => p.Name == brand.Name) != null)
                {
                    return new CustomResult(CustomResultType.Existed, "This ProdductBrand exists");
                }
                if (ModelState.IsValid(brand))
                {
                    db.ProductBrands.Add(brand);
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
                return new CustomResult(CustomResultType.UnexpectedError, ex.Message);
            }
        }
        public CustomResult EditProductBrand(ProductBrand brand)
        {
            try
            {
                if (db.ProductBrands.Find(brand.Id) == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "Can't find this ID to edit");
                }
                if (db.ProductBrands.FirstOrDefault(c => c.Name == brand.Name
                                         && c.Id != brand.Id) != null)
                {
                    return new CustomResult(CustomResultType.Existed, "This Product Brand exists");
                }
                if (ModelState.IsValid(brand))
                {
                    db.Set<ProductBrand>().AddOrUpdate(brand);
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
                return new CustomResult(CustomResultType.UnexpectedError, ex.Message);
            }
        }
        public CustomResult ChangeLockProductBrand(int id)
        {
            try
            {
                ProductBrand productBrand = db.ProductBrands.Find(id);
                if (productBrand == null)
                {
                    return new CustomResult(CustomResultType.NotExisted, "This Product Brand doesn't exist");
                }
                if (ModelState.IsValid(productBrand))
                {
                    productBrand.IsActive = !productBrand.IsActive;
                    db.Set<ProductBrand>().AddOrUpdate(productBrand);
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
                return new CustomResult(CustomResultType.UnexpectedError, ex.Message);
            }
        }
        public ProductBrand SearchProductBrandByID(int id)
        {
            try
            {
                return db.ProductBrands.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected errors have occcured, please contact your administrator\n" + ex.Message);
            }
        }
        public List<ProductBrand> SearchProductBrandByName(string name)
        {
            try
            {
                return db.ProductBrands.Where(s => s.Name.ToLower().Contains(name.ToLower())).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Some unexpected errors have occcured, please contact your administrator\n" + ex.Message);
            }
        }


    }
}
