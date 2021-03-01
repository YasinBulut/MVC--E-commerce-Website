using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using YeterZüccaciye.Models.Sınıflar;

namespace YeterZüccaciye.Models.Sınıflar
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }

        [Column(TypeName ="VarChar")]
        [StringLength(50)]
        public string Gönderen { get; set; }

        [Column(TypeName = "VarChar")]
        [StringLength(50)]
        public string Alici { get; set; }

        [Column(TypeName = "VarChar")]
        [StringLength(50)]
        public string Konu { get; set; }

        [Column(TypeName = "VarChar")]
        [StringLength(2000)]
        public string Icerik { get; set; }

        [Column(TypeName = "Smalldatetime")]
        public DateTime Tarih { get; set; }
    }
}