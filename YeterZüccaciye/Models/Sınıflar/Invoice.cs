using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YeterZüccaciye.Models.Sınıflar
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string InvoiceSERİNO { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string InvoiceSIRANO { get; set; }

        public DateTime Date { get; set; }
        [Column(TypeName = "char")]
        [StringLength(5)]
        public String Hour { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string Tax { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Selling { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Buyer { get; set; }
        public decimal Toplam { get; set; }
        public ICollection<Invoice_part> Invoice_Parts { get; set; }

    }
}