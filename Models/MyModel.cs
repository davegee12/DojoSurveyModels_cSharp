using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModel.Models
{
    public class Survey
    {
        [Display(Name = "Your Name:")]
        [Required]
        [MinLength(2)]
        public string name{get;set;}

        [Display(Name = "Your Location:")]
        [Required]
        public string location{get;set;}

        [Display(Name = "Favorite Coding Language:")]
        [Required]
        public string language{get;set;}

        [Display(Name = "Comment:")]
        [MinLength(20)]
        public string comment{get;set;}
    }
}