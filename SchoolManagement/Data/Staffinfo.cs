using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    [Table("StaffInfos")]
    public class Staffinfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int FacultyId { get; set; }

        [Column("FacultyName", Order = 1)]
        [MaxLength(18)]
        [MinLength(4)]
        [Required]
        public string FacultyName { get; set; }

        [Column(Order = 3)]
        public double Salary { get; set; }

        [Column("Subject", Order = 2)]
        [Required]
        public string Subject { get; set; }

        [Column("Gender", Order = 4)]
        [Required]
        public string Gender { get; set; }

        [Column("FacultyAddress", Order = 6)]
        public string FacultyAddress { get; set; }

        [Column("MobileNumber", Order = 5)]
        [Required]
        public string MobileNumber { get; set; }
    }
}
