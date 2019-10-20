using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QuanLySieuThi_Version2.Infrastructures;
namespace QuanLySieuThi_Version2.Models
{
    class Supplier
    {
        #region Constructors
        public Supplier() { IsActive = true; }
        public Supplier(string name, string address, string phoneNumber)
        {
            Name = name.Trim();
            Address = address.Trim();
            PhoneNumber = phoneNumber.Trim();
            IsActive = true;
        }
        public Supplier(string name, string address, string phoneNumber, bool isActive)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            IsActive = isActive;
        }
        #endregion

        #region Properties
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public bool IsActive {get; set;}
        #endregion

        #region Navigation Properties
        public virtual ObservableListSource<Product> Products { get; set; }
        #endregion
    }
}
