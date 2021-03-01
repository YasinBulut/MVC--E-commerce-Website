using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YeterZüccaciye.Models.Sınıflar
{
    public class Category
    {
        [Key]
        public int CATEGORYID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CATEGORYNAME { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}