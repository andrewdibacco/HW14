using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeDBEF.Models
{
    public class DepartmentTypes
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Department Type")]
        [StringLength(30)]
        public string Type { get; set; }
    }
}