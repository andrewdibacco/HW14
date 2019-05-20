using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace CollegeDBEF.Models
{
    public class Scores
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int ScoreTypesID { get; set; }
 
        [Required]
        public virtual ScoreTypes ScoreTypes { get; set; }

        [Required]
        public int StudentClassesID { get; set; }

        [Required]
        public virtual StudentClasses StudentClasses { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Display(Name = "Date Assigned")]
        [Required]
        public DateTime DateAssigned { get; set; }

        [Display(Name = "Due Date")]
        [Required]
        public DateTime DateDue { get; set; }

        [Display(Name = "Date Submitted")]
        [Required]
        public DateTime DateSubmitted { get; set; }

        [Display(Name = "Points Earned")]
        [Required]
        public int PointsEarned { get; set; }

        [Display(Name = "Points Possible")]
        [Required]
        public int PointsPossible { get; set; }
    }
}