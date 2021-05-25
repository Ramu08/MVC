using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class SchoolContext :DbContext
    {
        public SchoolContext() : base("name=SchoolContext")
        {
            
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}