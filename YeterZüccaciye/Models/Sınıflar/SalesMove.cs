using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YeterZüccaciye.Models.Sınıflar
{
    public class SalesMove
    {
        [Key]
        public int SalesID { get; set; }
        public DateTime SalesDate { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }

        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int PersonelID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Staff Staff { get; set; }
    }
}