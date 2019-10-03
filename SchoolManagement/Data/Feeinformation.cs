using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    [Table("Feeinformation")]
    public class Feeinformation
    {
        [Key]
        [Column("Class5",Order = 0)]
        [Required]
        public string Class5 { get; set; }

        [Column("Class6", Order = 1)]
        [Required]
        public string Class6 { get; set; }

        [Column("Class7", Order = 2)]
        [Required]
        public string Class7 { get; set; }

        [Column("Class8", Order = 3)]
        [Required]
        public string Class8 { get; set; }

        [Column("Class9", Order = 4)]
        [Required]
        public string Class9 { get; set; }

        [Column("Class10", Order = 5)]
        [Required]
        public string Class10 { get; set; }
    }
}









































/*[Table("Subjectmanagements")]
public class Subjectmanagement
{
    [Key]
    [Column("Subjectname", Order = 0)]
    public string Subjectname { get; set; }

    [Column("Subjectteacher", Order = 1)]
    public string Subjectteacher { get; set; }

    [Column("Seferencebook", Order = 2)]
    public string Referencebook { get; set; }*/