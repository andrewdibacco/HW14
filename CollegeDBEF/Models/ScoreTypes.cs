using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeDBEF.Models
{
    public class ScoreTypes
    {
        [Required]
        public int ID { get; set; }
        
        [Required]
        [Display(Name = "Score Type")]
        [StringLength(25)]
        public string Type { get; set; }
    }
}