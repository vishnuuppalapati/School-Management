using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    [Table("Libraries")]
    public class Library
    {
        [Key]
        [Column("Adminname",Order =0)]
        public string Administratorname { get; set; }

        [Column("Avlblesubjectbooks", Order = 2)]
        [Required]
        public string AvailableSubjectBooks { get; set; }

        [Column("SubjectAuthorslist", Order = 1)]
        public string SubjetAuthorslist { get; set; }
    }
}
