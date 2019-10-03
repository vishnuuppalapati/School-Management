using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    [Table("StudentsInfos")]
    public class Studentsinfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public long studentid { get; set; }

        [Column("Name", Order = 1)]
        [MaxLength(18)]
        [MinLength(4)]
        [Required]
        public string studentname { get; set;}

        [Column("standard",Order = 6)]
        [Required]
        public int standard {get;set; }

        [Column("DateofBirth", TypeName = "DateTime2")]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Column(Order =2)]
        [Required]
        public  int Age { get; set; }

        [Column("Gender", Order = 4)]
        [Required]
        public string Gender { get; set; }

        [Column("parentname",Order = 3)]
        [Required]
        public string parentname { get; set;}

        [Column("address",Order = 5)]
        [Required]
        public string address { get; set; }

        [Column("rank",Order = 7)]
        public int rank { get; set; }

        [Column(Order =8)]
        [Required]
        public byte[] Photo { get; set; }

    }
}
