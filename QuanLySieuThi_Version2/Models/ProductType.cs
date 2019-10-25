using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QuanLySieuThi_Version2.Infrastructures;
namespace QuanLySieuThi_Version2.Models
{
    class ProductType
    {
        #region Constructors
        public ProductType() { }
        public ProductType(string name)
        {
            Name = name;
            IsActive = true;
        }

        public ProductType(string name, bool isActive)
        {
            Name = name;
            IsActive = isActive;
        }
        #endregion

        #region Properties
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Index(IsUnique =true)]
        public string Name { get; set; }

        public bool IsActive { get; set; }
        #endregion

        #region Navigation Properties
        public  ObservableListSource<Product> Products { get; set; }
        #endregion
    }
}
