using System;
using System.ComponentModel.DataAnnotations;

namespace MyKitchen.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(60)]
        public string Name { get; set; }

        [Required, Range(1,100)]
        public float Carbs { get; set; }

        [Required, Range(1, 100)]
        public float Fats { get; set; }

        [Required, Range(1, 100)]
        public float Protein { get; set; }

        [Required]
        public float Calories { get; set; }

        [StringLength(250)]
        public string Notes { get; set; }
    }
}
