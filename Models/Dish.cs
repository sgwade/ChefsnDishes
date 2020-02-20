using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsDishes.Models
{
    public class Dish 
    {
        [Key]
        public int DishId {get; set;}

        [Required]
        [Display(Name="Name of Dish")]
        public string DishName {get; set;}

        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage="Calories must be greater than )")]
        [Display(Name="# of Calories")]
        public int Calories {get; set;}

        [Required]
        [Display(Name="Tastiness Level")]
        public int Tastiness {get; set;}

        [Required]
        [Display(Name="Description")]
        public string Description {get; set;}

        public int ChefId {get; set;}
        public Chef Chef {get; set;}

        public DateTime CreatedAt = DateTime.Now;
        public DateTime UpdatedAt = DateTime.Now;
    }
}