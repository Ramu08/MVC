using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public DateTime? DOB { get; set; }

        public decimal Height { get; set; }

        public float wieght { get; set; }


        public virtual Grade Grade { get; set; }
    }
}