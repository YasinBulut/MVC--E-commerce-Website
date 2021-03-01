using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YeterZüccaciye.Models.Sınıflar
{
    public class CargoDetay
    {
        [Key]
        public string CargoExplanationID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string CargoExplanation { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string TakipKodu { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string Personel { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string Alici { get; set; }
        public DateTime Tarih { get; set; }
    }
}