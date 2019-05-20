using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeDBEF.Models
{
    public class StudentClasses
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int ClassesID { get; set; }

        [Required]
        public virtual Classes Classes { get; set; }

        [Required]
        public int StudentsID { get; set; }

        [Required]
        public virtual Students Students { get; set; }
    }
}