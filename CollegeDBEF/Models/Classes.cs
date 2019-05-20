using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeDBEF.Models
{
    public class Classes
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int DepartmentTypesID { get; set; }

        [Required]
        public virtual DepartmentTypes DepartmentTypes { get; set; }

        [StringLength(50)]
        public string Instructor { get; set; }


    }
}