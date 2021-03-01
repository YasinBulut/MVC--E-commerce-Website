using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YeterZüccaciye.Models.Sınıflar
{
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CustomerNAME { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CustomerUSERNAME { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string CustomerCITY { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CustomerMAIL { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string  CustomerPassword { get; set; }
        public bool Status { get; set; }

        public ICollection<SalesMove> SalesMoves { get; set; }
    }
}