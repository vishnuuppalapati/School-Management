using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    [Table("Parentsinfos")]
    public class Parentsinfo
    {
        [Key]
        [Column("parentname", Order = 0)]
        [Required]
        public string parentname { get; set; }

        [Column("MobileNumber",Order =1)]
        [Required]
        public string MobileNumber { get; set; }

        [Column("EmailAddress",Order =2)]
        public string EmailAddress { get; set; }
    }
}
