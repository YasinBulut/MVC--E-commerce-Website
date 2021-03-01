using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YeterZüccaciye.Models.Sınıflar
{
    public class Staff
    {
        [Key]
        public int PersonelID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string PersonelAD { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string PersonelUSERNAME { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string PersonelIMAGE { get; set; }
        public ICollection<SalesMove> SalesMoves { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

    }
}