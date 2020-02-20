using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsDishes.Models 
{
    public class Chef
    {
        [Key]
        public int ChefId {get; set;}

        [Required]
        [Display(Name="First Name")]
        public string FirstName {get; set;}

        [Required]
        [Display (Name="Last Name")]
        public string LastName {get; set;}

        [Required]
        [Display(Name="Date of Birth")]
        public DateTime DateOfBirth {get; set;}
        public int Age {get; set;}

        public List<Dish> CreatedDishes {get; set;}
        public DateTime CreatedAt = DateTime.Now;
        public DateTime UpdatedAt = DateTime.Now;
    }
}