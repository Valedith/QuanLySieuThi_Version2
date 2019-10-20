using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QuanLySieuThi_Version2.Infrastructures;

namespace QuanLySieuThi_Version2.Models
{
    class Promotion
    {
        #region Constructors
        public Promotion() { }

        public Promotion(string name, float discountRate, DateTime startDate, DateTime endDate)
        {
            Name = name;
            DiscountRate = discountRate;
            StartDate = startDate;
            EndDate = endDate;
        }
        #endregion

        #region Properties
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0,1, ErrorMessage = "Discount Rate can't be lesser than 0 or greater than 1")]
        [Display(Name = "Discount Rate")]
        public float DiscountRate { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
        
        public bool IsActive { get; set; }
        #endregion

        #region Navigation Properties

        public ObservableListSource<Product> Products { get; set; }
        #endregion
    }
}
