using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi_Version2.Infrastructures;
namespace QuanLySieuThi_Version2.Models
{
    class Salary
    {
        public int Id { get; set; }
        public ObservableListSource<Customer> Customers { get; set; }
    }
}
