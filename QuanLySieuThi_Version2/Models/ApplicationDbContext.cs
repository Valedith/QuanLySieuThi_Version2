﻿using System.Data.Entity;

namespace QuanLySieuThi_Version2.Models
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Salary> Salaries { get; set; }
    }
}
