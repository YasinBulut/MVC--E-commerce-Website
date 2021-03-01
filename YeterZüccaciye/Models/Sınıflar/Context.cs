using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace YeterZüccaciye.Models.Sınıflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Invoice_part> Invoice_Parts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SalesMove> SalesMoves { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Detay> Detays { get; set; }
        public DbSet<Yapilacak> Yapilacaks  { get; set; }
        public DbSet<CargoDetay> CargoDetays  { get; set; }
        public DbSet<CargoTakip> CargoTakips  { get; set; }
        public DbSet<Message> Messages  { get; set; }

    }
}