using QuanLySieuThi_Version2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi_Version2.BUS
{
    class BaseBUS
    {
        protected ApplicationDbContext db;
        public BaseBUS()
        {
            db = new ApplicationDbContext();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
