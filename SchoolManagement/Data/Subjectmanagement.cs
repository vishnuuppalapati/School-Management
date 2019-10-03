using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{      
        [Table("Subjectmanagements")]
        public class Subjectmanagement
        {
            [Key]
            [Column("Subjectname", Order = 0)]
            [Required]
            public string Subjectname { get; set; }

            [Column("Subjectteacher", Order = 1)]
            [Required]
            public string Subjectteacher { get; set; }

            [Column("Referencebook", Order = 2)]
            public string Referencebook { get; set; }
        }
}
