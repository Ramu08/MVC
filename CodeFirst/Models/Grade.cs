using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Grade
    {
        public int GradeID { get; set; }

        public string GradeName { get; set; }

        public string GradeSection { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}