using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    [Table("examsmanagement")]
    public class Examsmgmt
    {
        [Key]
        [Column("ExaminationIncharge", Order =0 )]
        public string ExaminationIncharge { get; set;}

        [Column("Subjects",Order = 2)]
        public string Subjects { get; set; }

        [Column(Order = 1)]
        public int Marksinfo { get; set; }

    }
}
