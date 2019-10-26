using QuanLySieuThi_Version2.Infrastructures;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySieuThi_Version2.Models
{
    class ProductBrand
    {
        #region Constructors
        public ProductBrand() { }
        public ProductBrand(string brandName)
        {
            Name = brandName;
            IsActive = true;
        }
        public ProductBrand(string brandName, bool isActive)
        {
            Name = brandName;
            IsActive = isActive;
        }
        #endregion

        #region Properties
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public bool IsActive { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ObservableListSource<Product> Products { get; set; }
        #endregion

    }
}
