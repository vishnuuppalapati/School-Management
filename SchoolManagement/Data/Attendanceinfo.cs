using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    [Table("Attendanceinfos")]
    public class Attendanceinfo
    {

        [Key]
        [Column("AttendAdmin",Order =0)]
        public String AttendAdmin { get; set; }

        [Column("NoOfWorkingdays",Order =1)]
        [Required]
        public int NoOfWorkingdays { get; set; }

        [Column("NoOfPresentdays",Order=2)]
        public int NoOfPresentdays { get; set; }

        [Column("NoOfAbsentdays", Order = 3)]
        public int NoOfAbsentdays { get; set; }

        [Column("AttendencePercentage", Order =4 )]
        public float AttendancePercentage { get; set; }
    }
}
