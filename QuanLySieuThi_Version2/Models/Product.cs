using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QuanLySieuThi_Version2.Infrastructures;
namespace QuanLySieuThi_Version2.Models
{
    class Product
    {
        #region Properties
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int Quantity { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(450)]
        public string Detail { get; set; }

        public bool IsActive { get; set; }
        #endregion

        #region Navigation Properties
        public int ProductBrandId { get; set; }
        public virtual ProductBrand ProductBrand { get; set; }

        public  ObservableListSource<ProductType> ProductTypes { get; set; }

       public  ObservableListSource<Supplier> Suppliers { get; set; }

        public  ObservableListSource<Promotion> Promotions { get; set; }
        #endregion
    }
}
