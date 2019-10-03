using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    [Table("Transportationinfos")]
    public class Transportationinfo
    {
        [Key]
        [Column(Order =0)]
        public double busno { get; set; }

        [Column("drivername",Order =1)]
        [Required]
        public string drivername { get; set; }

        [Column("contactno",Order =2)]
        [Required]
        public string contactno { get; set; }

        [Column("route",Order =3)]
        [Required]
        public string route { get; set; }
    }
}
