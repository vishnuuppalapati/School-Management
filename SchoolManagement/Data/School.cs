using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    [Table("SchoolInfos")]
    public class School
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public long Id { get; set; }
        
        //[Key]
        [Column("Name",Order = 1)]
        [MaxLength(18)]
        [MinLength(4)]
        [Required]
        public string Name { get; set;}

        [Column("Address",Order = 3)]
        [Required]
        public string Address { get; set;}

        [Column("Lattitude",Order = 8)]
        public double Lattitude { get; set;}

        [Column("Longitude",Order = 9)]
        public double Longitude { get; set;}

        [Column("City",Order = 4)]
        [Required]
        public string City { get; set; }

        [Column("State",Order = 5)]
        [Required]
        public string State { get; set;}

        [Column("Country",Order = 6)]
        [Required]
        public string Country { get; set; }

        [Column(Order = 7)]
        [Required]
        public int PinCode { get; set; }

        [Column("MobileNumber",Order =2)]
        [Required]
        public string MobileNumber { get; set;}

        [NotMapped]
        public string SchoolName { get; set;}

        [Required]
        [Column("CreationTime",Order = 10)]
        public DateTime CreatedDate { get; set; }

        [Required]
        [Column("ModificationTime",Order = 11)]
        public DateTime ModifiedDate { get; set;}

        public string GetSchoolName()
        {
            return SchoolName=Name;
        }
    }

    
    
}
