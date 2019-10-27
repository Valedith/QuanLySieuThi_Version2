using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QuanLySieuThi_Version2.Infrastructures;
namespace QuanLySieuThi_Version2.Models
{
    class Product
    {
        public Product() { }
        public Product(string name, int quantity, decimal price, string detail, bool isActive, ProductBrand brand)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Detail = detail;
            IsActive = isActive;
            ProductBrand = brand;
        }
        public Product(string name, int quantity, decimal price, string unit,string detail, bool isActive, int brandId)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Unit = unit;
            Detail = detail;
            IsActive = isActive;
            ProductBrandId = brandId;
        }
        public Product(string name, int quantity, decimal price, string detail, string unit,bool isActive, int brandId, ProductBrand productBrand)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Unit = unit;
            Detail = detail;
            IsActive = isActive;
            ProductBrandId = brandId;
            ProductBrand = productBrand;
        }

        #region Properties
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Unit { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(450)]
        public string Detail { get; set; }

        public bool IsActive { get; set; }
        #endregion

        #region Navigation Properties
        public int ProductBrandId { get; set; }
        public virtual ProductBrand ProductBrand { get; set; }

        public ObservableListSource<ProductType> ProductTypes { get; set; }

        public ObservableListSource<Supplier> Suppliers { get; set; }

        public ObservableListSource<Promotion> Promotions { get; set; }
        #endregion

        [NotMapped]
        public string ProductBrandName
        {
            get
            {
                if (ProductBrand != null)
                {
                    return ProductBrand.Name;
                }
                return null;
            }
        }
    }
}
