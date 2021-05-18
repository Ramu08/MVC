using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Helper.Models
{
    public class SchoolModel :School
    {
        [Required]
        public int Id { get; set; }
        public string Department { get; set; }
        public int NumberofStudents { get; set; }
        public string Teachers { get; set; }
        public string Director { get; set; }
    }
}