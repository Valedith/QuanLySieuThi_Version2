using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi_Version2.Models.DTOs
{
    class SupplierProductDTO
    {
        public int SupplierId { get; set; }
        public int ProductId { get; set; }

        public string SupplierName { get; set; }
        public string ProductName { get; set; }
        public bool IsSupplying { get; set; }
    }
}
