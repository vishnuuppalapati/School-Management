using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SchoolManagement.Data.Subjectmanagement;

namespace SchoolManagement.Data
{
    public class SchoolContext:DbContext
    {
      

        public SchoolContext(DbContextOptions options) : base(options)
        {
        }
        //entities
        public DbSet<School> Schools { get; set; }
        public DbSet<Staffinfo> Staffinfos { get; set; }
        public DbSet<Studentsinfo> Studentsinfos{ get; set; }
        public DbSet<Parentsinfo> Parentsinfos{ get; set; }
        public DbSet<Transportationinfo> Transportationinfos { get; set; }
        public DbSet<Subjectmanagement> Subjectmanagements { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Attendanceinfo> Attendanceinfos { get; set; }
        public DbSet<Examsmgmt> Examsmgmts { get; set; }
        public DbSet<Feeinformation> Feeinformations { get; set; }
    }
}
