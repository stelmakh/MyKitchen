using System;
using System.ComponentModel.DataAnnotations;

namespace MyKitchen.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(60)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required, Range(1,100)]
        [Display(Name = "Carbs")]
        public float Carbs { get; set; }

        [Required, Range(1, 100)]
        [Display(Name = "Fats")]
        public float Fats { get; set; }

        [Required, Range(1, 100)]
        [Display(Name = "Protein")]
        public float Protein { get; set; }

        [Required]
        [Display(Name = "Calories")]
        public float Calories { get; set; }

        [StringLength(250)]
        [Display(Name = "Notes")]
        public string Notes { get; set; }
    }
}
