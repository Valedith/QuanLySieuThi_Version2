using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QuanLySieuThi_Version2.Infrastructures;
namespace QuanLySieuThi_Version2.Models
{
    class SupplierProduct
    {
        [Key]
        public int SupplierProductId { get; set; }


        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public bool IsSupplying { get; set; }
    }
}
