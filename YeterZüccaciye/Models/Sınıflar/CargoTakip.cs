using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YeterZüccaciye.Models.Sınıflar
{
    public class CargoTakip
    {
        [Key]
        public int CargoTakipID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string TakipKodu { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Açıklama { get; set; }
        public DateTime TarihZaman { get; set; }
    }
}