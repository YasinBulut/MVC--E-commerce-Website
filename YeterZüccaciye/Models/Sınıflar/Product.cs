using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YeterZüccaciye.Models.Sınıflar
{
    public class Product
    {
        [Key]
        public int PRODUCTID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string PRODUCTNAME { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string BRAND { get; set; }
        public short STOK { get; set; }
        public Decimal GETPRICE { get; set; }
        public Decimal SELLPRICE { get; set; }
        public bool STATUS { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string IMAGE { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<SalesMove> SalesMoves { get; set; }
    }
}