using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EF_CodeFirstModel.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("LOKESH")
        {
        }
        public DbSet<Student> Students { get; set; }

    }
}