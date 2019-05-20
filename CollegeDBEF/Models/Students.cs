using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeDBEF.Models
{
    public class Students
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Required]
        public int SSN { get; set; }

        [Required]
        [StringLength(125)]
        public string Address { get; set; }

        [Required]
        [StringLength(25)]
        public string City { get; set; }

        [Required]
        [StringLength(25)]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [Required]
        public int ZipCode { get; set; }

        [Required]
        public long Phone { get; set; }
    }
}