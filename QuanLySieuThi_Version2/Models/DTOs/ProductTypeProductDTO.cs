using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi_Version2.Models.DTOs
{
    class ProductTypeProductDTO
    {
        public int ProductTypeId { get; set; }
        public int ProductId { get; set; }
        public string ProductTypeName { get; set; }
        public string ProductName { get; set; }
    }
}
